namespace CountryRatingApps.Tests
{
    public class TypeTests
    {
        [Test]
        public void checkingIfTwoObjectsAreEqual()
        {
            var country1 = GetCountry("Thailand");
            var country2 = GetCountry("Thailand");
        
            Assert.AreEqual(country1.Name, country2.Name);
        }

        [Test]
        public void checkingIfTwoNumbersAreEqualOrNot()
        {
            float number1 = 5.4f;
            float number2 = 5.6f;
        
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void checkingIfTwoPeselNumbersAreEquals()
        {        
            string peselNumber1 = "90031111332";
            string peselNumber2 = "90031111332";

            Assert.AreEqual(peselNumber1, peselNumber2);
        }

        private Country GetCountry(string name)
        {
            return new Country(name);

        }
    }
}
