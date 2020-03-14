﻿using System;

namespace Proxy
{
    public class CarProxy : ICar
    {
        private Driver driver;
        private Car car = new Car();
        
        public CarProxy(Driver driver)
        {
            this.driver = driver;
        }
        public void Drive()
        {
            if (driver.Age >= 18)
                car.Drive();
            else
                Console.WriteLine("Driver is too young to drive!");
        }
    }
}
