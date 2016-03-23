/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;
using System.IO;

namespace T1
{
    /// <summary>
    /// This class ask text lines from users and writes those to file.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // write lines to file
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\T1TextLines.txt"))
            {
                do
                {
                    Console.Write("Give a text line (enter ends) : ");
                    line = Console.ReadLine();
                    if (line.Length != 0) outputFile.WriteLine(line);
                } while (line.Length != 0);
            }
            // read and print lines from file
            try
            {
                string text = File.ReadAllText(mydocpath + @"\T1TextLines.txt");
                Console.WriteLine("Contents of T1TextLines.txt:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
