namespace CountryStatistics
{
    public class CountryInMemory : CountryBase
    {
        private List<float> ImpressionsList { get; } = new List<float>();
        private List<float> NightlifeList { get; } = new List<float>();
        private List<float> LocalFoodList { get; } = new List<float>();
        private List<float> CostOfLivingList { get; } = new List<float>();

        public CountryInMemory(string name) : base(name) { }

        public override void AddImpressions(float impressions)
        {
            ImpressionsList.Add(impressions);
        }

        public override void AddNightlife(float nightlife)
        {
            NightlifeList.Add(nightlife);
        }

        public override void AddLocalFood(float localFood)
        {
            LocalFoodList.Add(localFood);
        }

        public override void AddCostOfLiving(float costOfLiving)
        {
            CostOfLivingList.Add(costOfLiving);
        }

        public override Statistics GetImpressionsStatistics()
        {
            return CalculateStatistics(ImpressionsList);
        }

        public override Statistics GetNightlifeStatistics()
        {
            return CalculateStatistics(NightlifeList);
        }

        public override Statistics GetLocalFoodStatistics()
        {
            return CalculateStatistics(LocalFoodList);
        }

        public override Statistics GetCostOfLivingStatistics()
        {
            return CalculateStatistics(CostOfLivingList);
        }

        public override int Result
        {
            get
            {
                float totalResult = 0;
                foreach (var list in new List<List<float>> { ImpressionsList, NightlifeList, LocalFoodList, CostOfLivingList })
                {
                    foreach (var score in list)
                    {
                        totalResult += score;
                    }
                }
                return (int)totalResult;
            }
        }

        private Statistics CalculateStatistics(List<float> values)
        {
            var statistics = new Statistics();
            foreach (var value in values)
            {
                statistics.AddScore(value);
            }
            return statistics;
        }
    }
}



