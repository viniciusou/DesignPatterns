using System;

namespace FactoryMethod
{
    /// <summary>
    /// "Factory methods deal with the problem of creating objects without having 
    /// to specify the exact class of the object that will be created. This is done 
    /// by creating objects by calling a factory method—either specified in an 
    /// interface and implemented by child classes, or implemented in a base class and 
    /// optionally overridden by derived classes—rather than by calling a constructor"
    ///  
    /// Point class has a private constructor and its objects are created by factory methods.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point);
        }
    }
}
