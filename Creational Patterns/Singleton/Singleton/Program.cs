using System;

namespace Singleton
{
    /// <summary>
    /// The singleton pattern restricts the instantiation of a class to one "single" 
    /// instance. This is useful when exactly one object is needed to coordinate 
    /// actions across the system.
    /// 
    /// Singleton is a component which is instantiated only once.
    /// Hides the constructor of the class. Defines a public static operation 
    /// that returns the sole instance of the class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var database = SingletonDatabase.Instance;
            var city = "Sao Paulo";
            Console.WriteLine($"{city} has population of {database.GetPopulation(city)}");
        }
    }
}
