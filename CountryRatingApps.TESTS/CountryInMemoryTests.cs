namespace CountryStatistics.Tests
{ 
    public class CountryInMemoryTests
    {
        [Test]
        public void WhenGetImpressionsCalled_ShouldReturnsCorrectStatistics()
        {       
            var country = new CountryInMemory("Thailand");
            country.AddImpressions(5);
            country.AddImpressions(7);
            country.AddImpressions(8);
         
            var statistics = country.GetImpressionsStatistics();
         
            Assert.AreEqual(6.67f, statistics.Average, 0.01f);
            Assert.AreEqual(5, statistics.Min);
            Assert.AreEqual(8, statistics.Max);
        }

        [Test]
        public void WhenGetNightlifeCalled_ReturnsCorrectStatistics()
        {
            var country = new CountryInMemory("Mexico");
            country.AddNightlife(4);
            country.AddNightlife(6);
            country.AddNightlife(8);

            var statistics = country.GetNightlifeStatistics();

            Assert.AreEqual(6, statistics.Average, 0.01f);
            Assert.AreEqual(4, statistics.Min);
            Assert.AreEqual(8, statistics.Max);
        }

        [Test]
        public void WhenGetLocalFoodCalled_ReturnsCorrectStatistics()
        {
            var country = new CountryInMemory("Poland");
            country.AddLocalFood(2);
            country.AddLocalFood(5);
            country.AddLocalFood(9);

            var statistics = country.GetLocalFoodStatistics();

            Assert.AreEqual(5.33f, statistics.Average, 0.01f);
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(9, statistics.Max);
        }

        [Test]
        public void WhenGetCostOfLivingCalled_shouldReturnsCorrectStatistics()
        {
            var country = new CountryInMemory("USA");
            country.AddCostOfLiving(3);
            country.AddCostOfLiving(6);
            country.AddCostOfLiving(8);

            var statistics = country.GetCostOfLivingStatistics();

            Assert.AreEqual(5.67f, statistics.Average, 0.01f);
            Assert.AreEqual(3, statistics.Min);
            Assert.AreEqual(8, statistics.Max);
        }
    }
}
