namespace CountryStatistics
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddScore(float score)
        {
            this.Count++;
            this.Sum += score;
            this.Min = Math.Min(score, this.Min);
            this.Max = Math.Max(score, this.Max);
        }
    }
}
