using System;

namespace Observer
{
    /// <summary>
    /// The observer pattern is a software design pattern in which an object, called the 
    /// subject, maintains a list of its dependents, called observers, and notifies them 
    /// automatically of any state changes, usually by calling one of their methods.
    /// 
    /// An observer is an object that wishes to be informed about events happening in the
    /// system. The entity generating the events is an observable.
    /// In this case, Person.FallsIll is the observable and CallDoctor is the observer.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FallsIll += CallDoctor;
            
            person.CatchACold();

            person.FallsIll -= CallDoctor;
        }

        private static void CallDoctor(object sender, FallsIllEventArgs eventArgs)
        {
            Console.WriteLine($"A doctor has been called to {eventArgs.Address}.");
        }
    }
}
