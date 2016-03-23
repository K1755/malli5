/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace ThrowException
{
    /// <summary>
    /// This class demonstrates how you can throw an exception and handle it in caller block.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 100;
            int number2 = 0;

            try
            {
                int result = SafeDivision(number1, number2);
                Console.WriteLine("{0} divided by {1} = {2}", number1, number2, result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted divide by zero.");
            }
            Console.ReadLine();
        }

        static int SafeDivision(int x, int y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }
    }
}
