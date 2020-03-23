using System;

namespace State.States
{
    // Concrete States implement various behaviors, associated with a state of
    // the Context.
    public class ConcreteStateA : BaseState
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of context.");
            _context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            throw new System.NotImplementedException();
        }
    }
}
