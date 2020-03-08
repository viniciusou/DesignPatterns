using System;

namespace InterfaceSegregation
{
    /// <summary>
    /// "Many client-specific interfaces are better than one general-purpose interface."
    /// 
    /// Broke interfaces into smaller interfaces so that Photocopier and MultiFunctionMachine
    /// implement only the necessary interfaces
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
