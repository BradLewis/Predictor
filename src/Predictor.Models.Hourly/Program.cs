using System;
using Predictor.Models.DataStructures.Hourly;
using Microsoft.ML;
using System.Collections.Generic;
using static Microsoft.ML.TrainCatalogBase;
using Microsoft.ML.Data;
using System.Linq;
using System.IO;

namespace Predictor.Models.Hourly
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new MLContext();
            //Train(ctx);
            Predict(ctx);
        }

        public static void Train(MLContext ctx)
        {
            const string path = "";
            var temperature = ctx.Data.LoadFromTextFile<Temperature>(path, separatorChar: ',', hasHeader: true);

            var trainer = ctx.Regression.Trainers.Sdca();

            var trainingPipeline = ctx.Transforms.Concatenate(outputColumnName: "Features", nameof(Temperature.NewYork), nameof(Temperature.Toronto))
                .Append(ctx.Transforms.CopyColumns(outputColumnName: "Label", inputColumnName: nameof(Temperature.Montreal)))
                .Append(trainer);

            var crossValidationResults = ctx.Regression.CrossValidate(data: temperature, estimator: trainingPipeline, labelColumnName: "Label");
            PrintRegressionFoldsAverageMetrics(trainer.ToString(), crossValidationResults);

            var model = trainingPipeline.Fit(temperature);

            const string outpath = "";
            ctx.Model.Save(model, temperature.Schema, outpath);
        }

        public static void PrintRegressionFoldsAverageMetrics(string algorithmName, IReadOnlyList<CrossValidationResult<RegressionMetrics>> crossValidationResults)
        {
            var L1 = crossValidationResults.Select(r => r.Metrics.MeanAbsoluteError);
            var L2 = crossValidationResults.Select(r => r.Metrics.MeanSquaredError);
            var RMS = crossValidationResults.Select(r => r.Metrics.RootMeanSquaredError);
            var lossFunction = crossValidationResults.Select(r => r.Metrics.LossFunction);
            var R2 = crossValidationResults.Select(r => r.Metrics.RSquared);

            Console.WriteLine($"*************************************************************************************************************");
            Console.WriteLine($"*       Metrics for {algorithmName} Regression model      ");
            Console.WriteLine($"*------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"*       Average L1 Loss:    {L1.Average():0.###} ");
            Console.WriteLine($"*       Average L2 Loss:    {L2.Average():0.###}  ");
            Console.WriteLine($"*       Average RMS:          {RMS.Average():0.###}  ");
            Console.WriteLine($"*       Average Loss Function: {lossFunction.Average():0.###}  ");
            Console.WriteLine($"*       Average R-squared: {R2.Average():0.###}  ");
            Console.WriteLine($"*************************************************************************************************************");
        }

        public static void Predict(MLContext ctx)
        {
            ITransformer trainedModel;
            const string modelPath = "";
            using (var stream = File.OpenRead(modelPath))
            {
                trainedModel = ctx.Model.Load(stream, out var modelInputSchema);
            }

            var predictionEngine = ctx.Model.CreatePredictionEngine<Temperature, Prediction>(trainedModel);

            Console.WriteLine("** Testing **");

            // Build sample data
            var dataSample = new Temperature()
            {
                NewYork = 288.24767617F,
                Toronto = 286.262540958F
            };

            // Predict the nextperiod/month forecast to the one provided
            Prediction prediction = predictionEngine.Predict(dataSample);
            Console.WriteLine($"Toronto: {dataSample.Toronto}, NYC: {dataSample.NewYork} - Montreal: {prediction.Score}");

        }

        class Prediction
        {
            public float Score { get; set; }
        }
    }
}
