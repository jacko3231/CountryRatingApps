namespace CountryStatistics
{
    class Program
    {
        private const string ResultFileName = "country_statistics.txt";

        static void Main(string[] args)
        {
            var countries = new List<ICountry>();

            Console.WriteLine("Welcome to the country assessment program!");
            Console.WriteLine("==========================================");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nEnter information about country which you want to rate! Country no {i + 1}:");
                string name = AskForCountryName();
                var country = new CountryInFile(name);
                countries.Add(country);

                AskAndAddRating("overall impression", country.AddImpressions);
                AskAndAddRating("nightlife", country.AddNightlife);
                AskAndAddRating("local food", country.AddLocalFood);
                AskAndAddRating("cost of living", country.AddCostOfLiving);

                SaveCountryStatisticsToFile(country);
            }

            PrintStatisticsForCountries(countries);
            PrintWinningCountry(countries);
        }

        static string AskForCountryName()
        {
            Console.Write("Country name: ");
            return Console.ReadLine();
        }

        static void AskAndAddRating(string aspect, Action<float> addRating)
        {
            while (true)
            {
                Console.Write($"How would you rate the {aspect} of this country (scale 1-10): ");
                string input = Console.ReadLine();
                if (input == "q")
                    break;

                if (float.TryParse(input, out float rating))
                {
                    addRating(rating);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 10.");
                }
            }
        }

        static void SaveCountryStatisticsToFile(ICountry country)
        {
            using (var writer = File.AppendText(ResultFileName))
            {
                writer.WriteLine($"Statistics for {country.Name}:");
                writer.WriteLine($"Average impressions: {country.GetImpressionsStatistics().Average:N2}");
                writer.WriteLine($"Average nightlife: {country.GetNightlifeStatistics().Average:N2}");
                writer.WriteLine($"Average local food: {country.GetLocalFoodStatistics().Average:N2}");
                writer.WriteLine($"Average cost of living: {country.GetCostOfLivingStatistics().Average:N2}");
                writer.WriteLine();
            }
        }

        static void PrintStatisticsForCountries(List<ICountry> countries)
        {
            foreach (var country in countries)
            {
                Console.WriteLine($"\nStatistics for {country.Name}:");
                Console.WriteLine($"Average impressions: {country.GetImpressionsStatistics().Average:N2}");
                Console.WriteLine($"Average nightlife: {country.GetNightlifeStatistics().Average:N2}");
                Console.WriteLine($"Average local food: {country.GetLocalFoodStatistics().Average:N2}");
                Console.WriteLine($"Average cost of living: {country.GetCostOfLivingStatistics().Average:N2}");
            }
        }

        static void PrintWinningCountry(List<ICountry> countries)
        {
            int maxResult = -1;
            ICountry countryWithMaxResult = null;

            foreach (var country in countries)
            {
                if (country.Result > maxResult)
                {
                    maxResult = country.Result;
                    countryWithMaxResult = country;
                }
            }

            if (countryWithMaxResult != null)
            {
                Console.WriteLine($"\nThe country with the highest points is {countryWithMaxResult.Name} and received {countryWithMaxResult.Result} points.");
            }
            else
            {
                Console.WriteLine("\nNo countries were rated.");
            }
        }
    }
}


