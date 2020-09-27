using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            // //LINQ-Language Integrated Query
            // int[] numbers = {12,56,34,67,13,25,67,89,39};

            // //Fetch numbers greater than 50
            // //using method syntax-Lambda expression
            // var numbersGreaterThan50 = numbers.Where (x => x>50);

            // //using sql query syntax-query expression
            // var numbersGreaterThanFifty = from num in numbers
            //                                 where num > 50
            //                                 select num;

            // string[] names = {"bishnu","ram","ramesh","james","raju","Ramsey"};

            // //names having length greater than 3 and starts with r
            // var result1 = names.Where(x => x.Length>3 && x.StartsWith("r"));
            // var result2 = from y in names
            //                 where y.Length>3 && y.ToLower().StartsWith("r")
            //                 select y;
            // foreach(var name in result2)
            // {
            //     Console.WriteLine(name);
            // } 

            var countries = Country.GetCountries();
            foreach (var country in countries)
            {
                if (country.IsInvaded)
                {
                    Console.WriteLine($"Name: {country.Name}\tContinent:{country.Continent}\tPopulation:{country.Population}\tArea:{country.Area}\tINVADED");
                }
                else if (!country.IsInvaded)
                {
                    Console.WriteLine($"Name: {country.Name}\tContinent:{country.Continent}\tPopulation:{country.Population}\tArea:{country.Area}\tNOT INVADED");
                }
            }

                          
        }
    }
}
