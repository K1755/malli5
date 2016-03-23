/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace WrongInputType
{
    /// <summary>
    /// This class demonstrates FormatException.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number : ");
            string line = Console.ReadLine();
            //int number = int.Parse(line);
            //Console.WriteLine("You gave number " + number);

            // corrected with exception handling
            try
            {
                int number = int.Parse(line);
                Console.WriteLine("You gave number " + number);
            } catch(FormatException)
            {
                Console.WriteLine("You don't gave a number!");
            }

            Console.ReadLine();
        }
    }
}
