using DependencyInversion.Interfaces;
using System;

namespace DependencyInversion
{
    //High-level module
    public class Research
    {
        public Research(IRelationshipBrowser browser)
        {
            var parent = "John";
            foreach(var person in browser.FindAllChildrenOf(parent))
            {
                Console.WriteLine($"{parent} has a child called {person.Name}");
            }
        }
    }
}
