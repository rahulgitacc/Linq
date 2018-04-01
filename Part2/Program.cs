using System;
using System.Collections.Generic;
using System.Linq;

namespace Part2
{
    class Program
    {
        static void Main()
        {
            //This all are dummy information
            var country = new List<Country>
            {
                new Country{ CountryName = "India", Population = "14%", State = 29, PhoneCode = "+91", Abbribiation = "IN" },
                new Country{ CountryName = "United States Of America", Population = "20%", State = 18, PhoneCode = "+01", Abbribiation = "USA" },
                new Country{ CountryName = "New Zealand", Population = "22%", State = 14, PhoneCode = "08", Abbribiation = "NZ" },
                new Country { CountryName = "Australia", Population = "17%", State = 19, PhoneCode = "+06", Abbribiation = "AU" }
            };

            foreach (var countryInfo in country.DesendingByState())
            {
                Console.WriteLine(countryInfo.CountryName);
            }
            Console.Read();
        }
    }

    /// <summary>
    /// Get/Set country property
    /// </summary>
    public class Country
    {
        public string CountryName { get; set; }
        public string Population { get; set; }
        public int State { get; set; }
        public string PhoneCode { get; set; }
        public string Abbribiation { get; set; }
    }

    /// <summary>
    /// LinqExtentionMethod
    /// </summary>
    public static class LinqExtentionMethod
    {
        public static IEnumerable<Country> DesendingByState(this IEnumerable<Country> countries)
        {
            return countries.OrderByDescending(x => x.State);
        }
    }
}
