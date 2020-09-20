using System;
namespace AllAboutClasses
{
    public class Country
    {
        
        public string Name{get;set;}
         public int Population { get; set; }
         public readonly double AREA=43443.45; 
         public static readonly bool IsOnEarth;

         //1.instance constructors
        //default constructor
                public Country()
        {
 
        }
        // Parameterized Constructor
        public Country(string name)
        {
            Name =name;
        }
 
        public Country(string name,int population, double area)
        {
            Name =name;
            Population = population;
            AREA = area;
        }

        //2.static constructors
        static Country()
        {
            IsOnEarth=true;
        }

        //Finalizer(destructor)
        ~Country()
        {
             Console.WriteLine('i am dying...');
        }
 
    }
    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country coountry2 = new Country("Nepal");
 
        }
    }
}