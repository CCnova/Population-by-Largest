using System;
using System.Collections.Generic;

namespace ArrayCollectionsPopByLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\CNova\Documents\Estagio\Curso Pluralsight C#\csharp-collections-beginning\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            int lilliputIndex = countries.FindIndex(x=>x.Population < 2_000_000);
            countries.Insert(lilliputIndex, lilliput);

            foreach(Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");

            }
        }
    }
}
