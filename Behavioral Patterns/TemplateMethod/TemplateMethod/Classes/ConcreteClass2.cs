﻿using System;

namespace TemplateMethod.Classes
{
    // Usually, concrete classes override only a fraction of base class' operations.
    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2 says: Overriden Hook1");
        }
    }
}
