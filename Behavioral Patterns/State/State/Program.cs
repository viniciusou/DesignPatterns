using State.States;
using System;

namespace State
{
    /// <summary>
    /// The state pattern is a behavioral software design pattern that allows an object 
    /// to alter its behavior when its internal state changes. The state pattern can be 
    /// interpreted as a strategy pattern, which is able to switch a strategy through 
    /// invocations of methods defined in the pattern's interface.
    /// 
    /// State is a pattern in which the object's behavior is determined by its state.
    /// An object transitions from one state to another (something needs to trigger a 
    /// transition).
    /// In this case the object transitions from ConcreteStateA to ConcreteStateB. The
    /// transitions are triggered by the methods Request1 and Request2.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }
    }
}
