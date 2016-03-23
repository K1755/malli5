/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace ImpossiblePostionInArray
{
    /// <summary>
    /// This class demonstrates IndexOutOfRangeException with arrays.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i=0;i<=5;i++)
            //{
            //    Console.Write("Number is " + numbers[i]);
            //}

            // corrected with exception handling
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Number is " + numbers[i]);
                }
            } catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Wrong index used in array!");
            }
            Console.ReadLine();
        }
    }
}
