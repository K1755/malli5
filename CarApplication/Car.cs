/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace CarApplication
{
    /// <summary>
    /// This class holds car properties. It throws CarException if car brand or model has no value.
    /// </summary>
    class Car
    {
        public string Brand { get; }
        public string Model { get; }

        public Car(string brand, String model)
        {
            if (brand.Equals(""))
            {
                throw new CarException("Car brand can't be empty!");
            }
            if (model.Equals(""))
            {
                throw new CarException("Car model can't be empty!");
            }
            Brand = brand;
            Model = model;
        }
    }
}
