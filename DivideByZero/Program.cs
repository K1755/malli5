/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace DivideByZero
{
    /// <summary>
    /// This class demonstrates DivideByZeroException.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // start
            int number1 = 100;
            int number2 = 0;
            //int result = number1 / number2;
            //Console.WriteLine("Result is {0}", result);

            // with exception handling
            try
            {
                int result = number1 / number2;
                Console.WriteLine("Result is {0}", result);
            } catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero!");
            }
            Console.ReadLine();
        }
    }
}
