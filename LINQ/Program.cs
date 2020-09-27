using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
             //LINQ-Language Integrated Query
             int[] numbers = {12,56,34,67,13,25,67,89,39};

             //Fetch numbers greater than 50
             //using method syntax-Lambda expression
             var numbersGreaterThan50 = numbers.Where (x => x>50);

             //using sql query syntax-query expression
             var numbersGreaterThanFifty = from num in numbers
                                             where num > 50
                                             select num;

             string[] names = {"bishnu","ram","ramesh","james","raju","Ramsey"};

             //names having length greater than 3 and starts with r
             var result1 = names.Where(x => x.Length>3 && x.StartsWith("r"));
             var result2 = from y in names
                             where y.Length>3 && y.ToLower().StartsWith("r")
                             select y;
             //projections
             var result5 = from num in numbers
                            select num*num;
            //ordering
            var result6 = from num in numbers
                            orderby num
                            select num;
            //partitioning
            var result7 = numbers.Skip(5).Take(5);
            
            //Quantifier
            var result8 = numbers.Any(x => x % 2==0);
            var result9 = numbers.All(x => x % 2==0);
            var result10 = numbers.Contains(34);

            var result11 = Enumerable.Range(1,1000);
            var result12 = Enumerable.Repeat("Hello World!",10);

            foreach (var square in result12)
            {
                Console.WriteLine(square);
            }     
            

                          
        }
    }
}
