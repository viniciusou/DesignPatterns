using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Drinks
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is sensational!");
        }
    }
}
