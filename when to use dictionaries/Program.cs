namespace when_to_use_dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital =  "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washington D.C" };
            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

            Dictionary<string, Country> dictionaryCountry = new Dictionary<string, Country>();
            dictionaryCountry.Add(country1.Code, country1 );
            dictionaryCountry.Add(country2.Code, country2);
            dictionaryCountry.Add(country3.Code, country3);
            dictionaryCountry.Add(country4.Code, country4);
            dictionaryCountry.Add(country5.Code, country5);

            string StrUseChoice = string.Empty;

            do { 

            Console.WriteLine("Please Enter Country Code");
            string StrCountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = dictionaryCountry.ContainsKey(StrCountryCode) ? dictionaryCountry[StrCountryCode] : null ;

            if (resultCountry == null )
            {
                Console.WriteLine("Country Code not valid");
            }
            else
            {
                Console.WriteLine($"Name = {resultCountry.Name}, Capital = {resultCountry.Capital}");
            }
                do { 
                Console.WriteLine("Do we want to continue - YES or NO");
                StrUseChoice = Console.ReadLine().ToUpper();
                }while (StrUseChoice != "NO" && StrUseChoice != "YES");
            } while (StrUseChoice == "YES");
        }
    }

    //purpose of creating a thread is to executed a function
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
    }
}