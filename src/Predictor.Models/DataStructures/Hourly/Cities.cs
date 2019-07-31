using Microsoft.ML.Data;

namespace Predictor.Models.DataStructures.Hourly
{
    public abstract class Cities<T>
    {
        [LoadColumn(1)]
        public T Vancouver { get; set; }

        [LoadColumn(2)]
        public T Portland { get; set; }

        [LoadColumn(3)]
        public T SanFrancisco { get; set; }

        [LoadColumn(4)]
        public T Seattle { get; set; }

        [LoadColumn(5)]
        public T LosAngeles { get; set; }

        [LoadColumn(6)]
        public T SanDiego { get; set; }

        [LoadColumn(7)]
        public T LasVegas { get; set; }

        [LoadColumn(8)]
        public T Pheonix { get; set; }

        [LoadColumn(9)]
        public T Albuquerque { get; set; }

        [LoadColumn(10)]
        public T Denver { get; set; }

        [LoadColumn(11)]
        public T SanAntonio { get; set; }

        [LoadColumn(12)]
        public T Dallas { get; set; }

        [LoadColumn(13)]
        public T Houston { get; set; }

        [LoadColumn(14)]
        public T KansasCity { get; set; }

        [LoadColumn(15)]
        public T Minneapolis { get; set; }

        [LoadColumn(16)]
        public T SaintLouis { get; set; }

        [LoadColumn(17)]
        public T Chicago { get; set; }

        [LoadColumn(18)]
        public T Nashville { get; set; }

        [LoadColumn(19)]
        public T Indianapolis { get; set; }

        [LoadColumn(20)]
        public T Atlanta { get; set; }

        [LoadColumn(21)]
        public T Detroit { get; set; }

        [LoadColumn(22)]
        public T Jacksonville { get; set; }

        [LoadColumn(23)]
        public T Charlotte { get; set; }

        [LoadColumn(24)]
        public T Miami { get; set; }

        [LoadColumn(25)]
        public T Pittsburgh { get; set; }

        [LoadColumn(26)]
        public T Toronto { get; set; }

        [LoadColumn(27)]
        public T Philadelphia { get; set; }

        [LoadColumn(28)]
        public T NewYork { get; set; }

        [LoadColumn(29)]
        public T Montreal { get; set; }

        [LoadColumn(30)]
        public T Boston { get; set; }

        [LoadColumn(31)]
        public T Beersheba { get; set; }

        [LoadColumn(32)]
        public T TelAvivDistrict { get; set; }

        [LoadColumn(33)]
        public T Eilat { get; set; }

        [LoadColumn(34)]
        public T Haifa { get; set; }

        [LoadColumn(35)]
        public T Nahariyya { get; set; }

        [LoadColumn(36)]
        public T Jerusalem { get; set; }
    }
}
