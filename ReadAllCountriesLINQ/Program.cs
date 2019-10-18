using System;
using System.Collections.Generic;
using System.Linq;
using TopTenPops;

namespace ReadAllCountriesLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountriesList();

            //Limit the enumeration to 10 = country.Take(10)
            //OrderBy must receive an Lambda expression = OrderBy(x=>x.Name)
            //Where query for items that satisfy a condition using a lambda expression
            foreach (var country in countries.Take(10).Where(x=>!x.Name.Contains(',')))
            {
                Console.WriteLine($"Population: {country.Population}");
            }
        }
    }
}
