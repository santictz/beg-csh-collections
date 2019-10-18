using System;
using System.Collections.Generic;
using TopTenPops;

namespace DictSnippets
{
    class Program
    {
        static void Main(string[] args)
        {
            Country norway = new Country("Norway", 69099, "Europe", "NOR");
            Country finland = new Country("Finland", 231123, "Europe", "FIN");
            //Dictionaries contains Keys and Values (generics)
            var countries = new Dictionary<string, Country>
            {
                { norway.Code, norway },
                { finland.Code, finland }
            };
            //Find a value in a dictionary
            Country selectedCountry = countries["NOR"];
            //A best way to find values is to use TryGetValue method
            bool exists = countries.TryGetValue("MUS", out Country country);
            if (exists)
            {
                Console.WriteLine(country.Name);
            }
            else
            {
                Console.WriteLine("There is no country with code MUS");
            }
            //Enumerate dictionaries using KeyParValues
            foreach (var countri in countries.Values)
            {
                Console.WriteLine(countri.Name);
            }
        }
    }
}
