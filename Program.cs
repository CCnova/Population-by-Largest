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

            foreach(Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");

            }
        }
    }
}
