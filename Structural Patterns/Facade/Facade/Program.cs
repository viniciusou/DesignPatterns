using Facade.Subsystems;

namespace Facade
{
    /// <summary>
    /// Analogous to a facade in architecture, a facade is an object that serves as a 
    /// front-facing interface masking more complex underlying or structural code.
    /// A Facade is used when an easier or simpler interface to an underlying object 
    /// is desired.
    /// 
    /// The facade provides a simple, easy to understand user interface over a large
    /// and sophisticated body of code.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);

            Client.ClientCode(facade);
        }
    }
}
