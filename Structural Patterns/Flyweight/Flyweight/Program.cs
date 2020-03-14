using System;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
    /// <summary>
    /// A flyweight is an object that minimizes memory usage by sharing as much data as 
    /// possible with other similar objects. It is a way to use objects in large numbers 
    /// when a simple repeated representation would use an unacceptable amount of memory.
    /// 
    /// Flyweight objects store intrinsic (invariant) state that can be shared and
    /// provide an interface through which extrinsic (variant) state can be passed in.
    /// In this case, the UserFlyWeight stores full names so that repeated names do not
    /// allocate more memory.
    /// </summary>  
    class Program
    {
        static void Main(string[] args)
        {
            var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

            var users = new List<User>();

            foreach (var firstName in firstNames)
                foreach (var lastName in lastNames)
                    users.Add(new User($"{firstName} {lastName}"));

            ForceGC();

            foreach (var user in users)
                Console.WriteLine(user);

            var usersFlyWeight = new List<User>();

            foreach (var firstName in firstNames)
                foreach (var lastName in lastNames)
                    usersFlyWeight.Add(new User($"{firstName} {lastName}"));

            ForceGC();

            foreach (var userFlyWeight in usersFlyWeight)
                Console.WriteLine(userFlyWeight);
        }

        private static void ForceGC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static string RandomString()
        {
            Random random = new Random();

            return new string(
                Enumerable.Range(0, 10)
                .Select(i => (char)('a' + random.Next(26)))
                .ToArray());
        }
    }
}
