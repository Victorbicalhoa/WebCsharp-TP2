namespace TP2.Models
{
    public class Country
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

        public Country(string name, string code)
        {
            CountryName = name;
            CountryCode = code;
        }
    }
}