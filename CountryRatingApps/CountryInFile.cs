namespace CountryStatistics
{
    public class CountryInFile : CountryBase
    {
        private const string FileName = "country_scores.txt";
        private readonly object lockObject = new object();
        private float result;

        public override int Result => (int)result;

        public CountryInFile(string name) : base(name) { }

        public override void AddImpressions(float impressions)
        {
            result += impressions;
            WriteScoreToFile(impressions);
        }

        public override void AddNightlife(float nightlife)
        {
            result += nightlife;
            WriteScoreToFile(nightlife);
        }

        public override void AddLocalFood(float localFood)
        {
            result += localFood;
            WriteScoreToFile(localFood);
        }

        public override void AddCostOfLiving(float costOfLiving)
        {
            result += costOfLiving;
            WriteScoreToFile(costOfLiving);
        }

        public override Statistics GetImpressionsStatistics()
        {
            return ReadScoresFromFileToList();
        }

        public override Statistics GetNightlifeStatistics()
        {
            return ReadScoresFromFileToList();
        }

        public override Statistics GetLocalFoodStatistics()
        {
            return ReadScoresFromFileToList();
        }

        public override Statistics GetCostOfLivingStatistics()
        {
            return ReadScoresFromFileToList();
        }

        private void WriteScoreToFile(float score)
        {
            lock (lockObject)
            {
                using (var writer = File.AppendText(FileName))
                {
                    writer.WriteLine(score);
                }
            }
        }

        private Statistics ReadScoresFromFileToList()
        {
            var statistics = new Statistics();
            lock (lockObject)
            {
                if (File.Exists(FileName))
                {
                    using (var reader = File.OpenText(FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (float.TryParse(line, out float value))
                            {
                                statistics.AddScore(value);
                            }
                        }
                    }
                }
            }
            return statistics;
        }
    }
}

