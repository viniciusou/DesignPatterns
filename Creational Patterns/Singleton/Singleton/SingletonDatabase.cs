using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Singleton
{
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;

        private SingletonDatabase()
        {
            Console.WriteLine("Initializing database");

            capitals = File.ReadAllLines("capitals.txt")
                .Batch(2)
                .ToDictionary(
                    list => list.ElementAt(0).Trim(),
                    list => int.Parse(list.ElementAt(1))
                );
        }

        private static Lazy<SingletonDatabase> instance =
            new Lazy<SingletonDatabase>(() => new SingletonDatabase());

        public static SingletonDatabase Instance => instance.Value;
        
        public int GetPopulation(string name)
        {
            return capitals[name];
        }
    }
}
