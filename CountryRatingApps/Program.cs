﻿using CountryRatingApps;
using System.Diagnostics.Metrics;

Country country1 = new Country("Thailand");
Country country2 = new Country("Mexico");
Country country3 = new Country("Poland");
Country country4 = new Country("Egypt");


country1.AddPoint(5);
country1.AddPoint(6);
country1.AddPoint(7);
country1.AddPoint(1);
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

List<Country> countries = new List<Country>()
{
    country1, country2, country3, country4
};

int maxResult = -1;
Country countryWithMaxPoints = null;

foreach(var country in countries)
{
    if(country.Result > maxResult)
    {
        countryWithMaxPoints = country;
    }
}


Console.WriteLine(countryWithMaxPoints.Name);






