using Builder.Builders;
using System;

namespace Builder
{
    /// <summary>
    /// "The intent of the Builder design pattern is to separate the construction 
    /// of a complex object from its representation. By doing so the same construction 
    /// process can create different representations."
    /// "A class (the same construction process) can delegate to different Builder 
    /// objects to create different representations of a complex object."
    /// 
    /// Builder provides an API for constructing the Person object step-by-step.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var personBuilder = new PersonBuilder();
            Person person = personBuilder
                .Works.At("CompanyA")
                      .AsA("Developer")
                      .Earning(123000)
                .Lives.At("123 London Street")
                      .WithPostcode("123456")
                      .In("London");

            Console.WriteLine(person);
        }
    }
}
