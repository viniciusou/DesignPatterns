using ChainOfResponsibility.Modifiers;
using System;

namespace ChainOfResponsibility
{
    /// <summary>
    ///  The Chain of Responsibility pattern is a design pattern consisting of a source 
    ///  of command objects and a series of processing objects. Each processing object 
    ///  contains logic that defines the types of command objects that it can handle. The 
    ///  rest are passed to the next processing object in the chain. A mechanism also exists 
    ///  for adding new processing objects to the end of this chain.
    ///  
    /// A chain of components who all get a chance to process a command or a query, optionally
    /// having default processing implementation and an ability to terminate the processing
    /// chain.
    /// In this case, DoubleAttackModifier and IncreasedDefenseModifier are components
    /// of the chain of responsibility. CreatureModifier is the head (root) of the chain.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var goblin = new Creature("goblin", 2, 2);
            Console.WriteLine(goblin);

            var root = new CreatureModifier(goblin);

            Console.WriteLine("Let's double the goblin's attack");
            root.Add(new DoubleAttackModifier(goblin));
            root.Add(new IncreasedDefenseModifier(goblin));
            root.Handle();
            Console.WriteLine(goblin);
        }
    }
}
