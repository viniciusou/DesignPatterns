﻿using System;

namespace Proxy
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Car is being driven!");
        }
    }
}
