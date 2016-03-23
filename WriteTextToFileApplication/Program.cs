/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

// Uncomment different code blocks to demonstrate different writing scenarios

namespace WriteTextToFileApplication
{
    /// <summary>
    /// This application demonstrates how to write text to file and handle different exceptions.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 1. write text file with hard coded file path, no exception handling
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"c:\test.txt");
            outputFile.WriteLine("Here is a sample text to file.");
            outputFile.Close();

            // 2. write text file to same folder where compile exe is located
            //System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"test.txt");
            //outputFile.WriteLine("Here is a sample text to file.");
            //outputFile.Close();

            // 3. handle a few common exceptions
            /*
            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter("test.file");
                outputFile.WriteLine("Here is a sample text to file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Can't open file for writing (UnauthorizedAccessException)");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Opened stream is null (ArgumentNullException)");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Opened stream is not writable (ArgumentException)");
            }
            catch (IOException)
            {
                Console.WriteLine("An IO error happend (IOException)");
            }
            catch (Exception)
            {
                Console.WriteLine("Some other exception happend (Exception)");
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
            */

            // 4. use Exception only
            /*
            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter(@"c:\test.file");
                outputFile.WriteLine("Here is a sample text to file.");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Some exception happened!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
            */

            // 5. variable to the My Documents path
            /*
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] lines = { "First line", "Second line", "Third line" };
            // write the string array to a new file named "WriteLines.txt".
            // IDisposable object use using!
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteLines.txt")) // escape sequences are ignored
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }
            */

            // 6. WriteAll-method
            /*
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] lines = { "First line", "Second line", "Third line" };
            File.WriteAllLines(mydocpath + @"\WriteAllLines.txt", lines);
            */

            Console.WriteLine();
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
