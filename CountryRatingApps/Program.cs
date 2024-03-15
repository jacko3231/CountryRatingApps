using CountryRatingApps;

Country country1 = new Country("Thailand");
Country country2 = new Country("Mexico");
Country country3 = new Country("Poland");
Country country4 = new Country("Egypt");


country1.AddPoint(5);
country1.AddPoint(6);
country1.AddPoint(7);
country1.AddPoint(9);
country1.AddPoint(9);

var result1 = country1.Result;

country2.AddPoint(5);
country2.AddPoint(3);
country2.AddPoint(1);
country2.AddPoint(2);
country2.AddPoint(4);

var result2 = country2.Result;

country3.AddPoint(8);
country3.AddPoint(9);
country3.AddPoint(9);
country3.AddPoint(9);
country3.AddPoint(1);

var result3 = country3.Result;

country4.AddPoint(1);
country4.AddPoint(2);
country4.AddPoint(9);
country4.AddPoint(6);
country4.AddPoint(5);

var result4 = country4.Result;

Console.WriteLine($"Country {country1.Name} recevied {country1.Result} points");
Console.WriteLine($"Country {country2.Name} recevied {country2.Result} points");
Console.WriteLine($"Country {country3.Name} recevied {country3.Result} points");
Console.WriteLine($"Country {country4.Name} recevied {country4.Result} points");

if(result1 > result2 && result1 > result3 && result1 > result4)
{
    Console.WriteLine($" Country which recevied the most points is {country1.Name} with {country1.Result} points");
}
else if(result2 > result1 && result2 > result3 && result2 > result4)
{
    Console.WriteLine($" Country which recevied the most points is {country2.Name} with {country2.Result} points");
}
else if(result3 > result1 && result3 > result2 && result3 > result4)
{
    Console.WriteLine($" Country which recevied the most points is {country3.Name} with {country3.Result} points");
}
else if(result4 > result1 && result4 > result2 && result4 > result3)
{
    Console.WriteLine($" Country which recevied the most points is {country4.Name} with {country4.Result} points");
}








