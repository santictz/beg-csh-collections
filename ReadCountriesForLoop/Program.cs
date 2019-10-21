using System;
using TopTenPops;
using System.Collections.Generic;

namespace ReadCountriesForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"";

            CsvReader reader = new CsvReader(filepath);

            List<Country> countries = reader.ReadAllCountriesList();
            //If country contains comma, is deleted from the list
            reader.RemoveCommaCountries(countries);

            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type in a +ve integer. Exiting");
                return;
            }

            int maxToDisplay = userInput;
            for (int i = 0; i < countries.Count; i++)
            {
                if (i > 0 && (i % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continuem, anything else to quit");
                    if (Console.ReadLine() == "")
                    {
                        break;
                    }
                }
                Country country = countries[i];
                Console.WriteLine($"{i+1}: Population: {country.Population}");
            }
        }
    }
}
