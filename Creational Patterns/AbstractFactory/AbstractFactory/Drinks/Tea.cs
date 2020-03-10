using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Drinks
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is nice but I'd prefer it with milk.");
        }
    }
}
