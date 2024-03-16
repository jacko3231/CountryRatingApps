namespace CountryRatingApps.Tests
{
    public class Tests
    {
        [Test]
        public void WhenCountryCollectSetOfPointsThenShouldReturnResult()
        {
            // Arrange 

            var country = new Country("UK");
            country.AddPoint(5);
            country.AddPoint(7);
            country.AddPoint(8);
            country.AddPoint(1);

            // Act         
            var result = country.Result;
            
            //Assert

            Assert.AreEqual(21, result);
        }
    }
}