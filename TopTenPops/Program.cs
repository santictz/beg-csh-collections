using System;
using System.Collections.Generic;

namespace TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"";
            CsvReader reader = new CsvReader(filepath);

            Dictionary<string, Country> countries = reader.ReadAllCountries();


            //Country lilliput = new Country("Lilliput", 200, "Somewhere", "LIL");
            //Takes an predicate: expression that returns a boolean
            //int lilliputindex = countries.FindIndex(x=>x.Population < 200);
            //countries.Insert(lilliputindex, lilliput);
            //Remove the element of the list in the indicated index
            //countries.RemoveAt(lilliputindex);

            Console.WriteLine("Which country do you want to look up?");
            string userInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(userInput, out Country country);

            if (gotCountry)
            {
                Console.WriteLine($"{country.Name} has a population of {country.Population}");
            }
            else
            {
                Console.WriteLine($"Sorry, there is no country with the code {userInput}");
            }

            //Works from List and Array
            //foreach (var country in countries)
            //{
            //    Console.WriteLine($"{country.Population}: {country.Name}");
            //}
        }
    }
}
