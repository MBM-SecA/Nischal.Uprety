﻿// using System;


//     class Program
//     {
//         static void Main1()
//         {
//             //value types
//             //1.numbers
//             //1.1integers
//             byte a=12;
//             short b=35;
//             int c=3545;
//             long d=54236215376;


//             //1.2floating numbers
//             float e=23.45f;
//             double f=4234.42352;
//             decimal g=5423524.263526146m;

//             //2.characters
//             char h='h';

//             //3.boolean
//             bool i=true;


//             //Reference types
//             string j="jafhjhf";
//             object k="j diye ni hunxa yesma";
//         }
//     }
using LearnCollections;
using  System;
using System.IO;
using System.Linq;

public class Program
{
    static void Main()
    {
       string countriesText=File.ReadAllText("Countries.txt");
       string[] countries=countriesText.Split("\r\n");
       var countriesWithNInitial = countries.Where( x => x.StartsWith("N")).Select(x =>x);
       foreach(var country in countriesWithNInitial)
       {
           Console.WriteLine(country);
       }

    }
}

