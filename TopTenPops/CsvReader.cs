using System.Collections.Generic;
using System.IO;

namespace TopTenPops
{
    public class CsvReader
    {
        private readonly string _filepath;

        public CsvReader(string filepath)
        {
            this._filepath = filepath;
        }

        public Dictionary<string, Country> ReadAllCountries()
        {
            var countries = new Dictionary<string, Country>();

            //Dispose streamreader once it is not being used
            using (StreamReader sr = new StreamReader(_filepath))
            {
                //read header line
                sr.ReadLine();
                string csvLine;

                //Readline returns null at the end of the file
                while ((csvLine = sr.ReadLine()) != null)
                {
                    Country country = ReadCountryFromCsvLine(csvLine);
                    countries.Add(country.Code, country);
                }
            }

            return countries;
        }

        public List<Country> ReadAllCountriesList()
        {
            var countries = new List<Country>();

            //Dispose streamreader once it is not being used
            using (StreamReader sr = new StreamReader(_filepath))
            {
                //read header line
                sr.ReadLine();
                string csvLine;

                //Readline returns null at the end of the file
                while ((csvLine = sr.ReadLine()) != null)
                {
                    countries.Add(country);
                }
            }

            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            string name;
            string code;
            string region;
            string popText;

            if (parts.Length == 4)
            {
                name = parts[0];
                code = parts[1];
                region = parts[2];
                popText = parts[3];
            }
            else
            {
                name = parts[0] + ", " + parts[1];
                name = name.Replace("\"", null).Trim();
                code = parts[2];
                region = parts[3];
                popText = parts[4];
            }
            //Leaves population to 0 if it cannot be parsed
            int.TryParse(popText, out int population);

            return new Country(name, population, region, code);
        }
    }
}