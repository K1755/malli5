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

namespace ReadTextFileToApplication
{
    /// <summary>
    /// This class demonstrates how to read text file with ReadAllText and ReadAllLines commands.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // 1.read all content as a one string
            try {
                string text = System.IO.File.ReadAllText(mydocpath + @"\WriteLines.txt");
                System.Console.WriteLine("Contents of test.txt:\n" + text);
            } catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
            
            // 2. read all lines, output one line in foreach
            try
            {
                string[] lines = System.IO.File.ReadAllLines(mydocpath + @"\WriteLines.txt");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
            

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();

        }
    }
}
