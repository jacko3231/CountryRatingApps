namespace CountryRatingApps.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            //arrange

            var country1 = GetCountry("Vietnam");
            var country2 = GetCountry("Vietnam");

            //act

            //assert
            Assert.AreEqual(country1, country2);
        }

        private Country GetCountry(string name)
        {
            return new Country(name);

        }
    }
}
