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
    /// This class demonstrates own made CarException use case.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Car car = new Car("Audi", "");
                Console.WriteLine("Car brand is {0} and model is {1}", car.Brand, car.Model);
            } catch (CarException ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
