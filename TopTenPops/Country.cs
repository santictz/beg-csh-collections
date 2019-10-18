namespace TopTenPops
{
    public class Country
    {
        public string Name { get; }
        public int Population { get; }
        public string Code { get; }
        public string Region { get; }

        public Country(string name, int population, string region, string code)
        {
            this.Name = name;
            this.Population = population;
            this.Code = code;
            this.Region = region;
        }
    }
}