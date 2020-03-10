using System;

namespace Prototype
{
    /// <summary>
    /// The prototype pattern is used when the type of objects to create is determined 
    /// by a prototypical instance, which is cloned to produce new objects.
    /// 
    /// A prototype is a partially or fully initialized object that you copy (clone)
    /// and make use of it. Person is copied (cloned) using an extension method.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[] { "John", "Smith" },
                new Address("London Road", 123));

            var jane = john.DeepCopy();
            jane.Names[0] = "Jane";
            jane.Address.HouseNumber = 321;

            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}
