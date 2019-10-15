using System;
using System.Collections.Generic;

namespace ArrayCollectionsPopByLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change this variable to the path of your file
            string filePath = @"C:\Users\CNova\Documents\Estagio\Curso Pluralsight C#\csharp-collections-beginning\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);
            Dictionary<string, Country> countries = reader.ReadAllCountries();

            Console.WriteLine("Wich country code do you want to look up? ");
            string userInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(userInput, out Country country);
            if(!gotCountry)
            {
                Console.WriteLine($"Sorry, there is no country with code, {userInput}");
            }

            else
            {
                Console.WriteLine($"{country.Name} has population {PopulationFormatter.FormatPopulation(country.Population)}");
            }
        }
    }
}
