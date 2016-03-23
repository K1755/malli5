/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WriteObjectToFileApplication
{
    /// <summary>
    /// This class demonstrates how to write/read object to disk.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            // 1. write one person to file
            Person person = new Person { Firstname = "Jukka", Lastname = "Husso" };
            Debug.WriteLine("Write one object to disk: {0} {1}",person.Firstname,person.Lastname);
            Stream writeStream = new FileStream("MyPerson.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeStream, person);
            writeStream.Close();

            // 2. read person
            Stream readStream = new FileStream("MyPerson.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            Person readPerson = (Person)formatter.Deserialize(readStream);
            Console.WriteLine();
            Console.WriteLine("Read one person from disk:");
            Console.WriteLine("Person is {0} {1}", person.Firstname, person.Lastname);

            // 3. write multiple persons to file
            Console.WriteLine();
            Console.WriteLine("Write multiple persons to disk.");
            List<Person> persons = new List<Person>();
            persons.Add(new Person { Firstname = "Kirsi", Lastname = "Kerneli" });
            persons.Add(new Person { Firstname = "Matti", Lastname = "Konsoli" });
            persons.Add(new Person { Firstname = "Teppo", Lastname = "Terävä" });

            // write persons to file
            Stream writeMultipleStream = new FileStream("MyPersons.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(writeMultipleStream, persons);
            writeMultipleStream.Close();

            // read persons from file
            Console.WriteLine();
            Console.WriteLine("Read multiple persons from disk:");
            Stream openStream = new FileStream("MyPersons.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Person> readPersons = (List<Person>)formatter.Deserialize(openStream);
            openStream.Close();

            // proof
            foreach(Person p in readPersons)
            {
                Console.WriteLine("Person is {0} {0}", p.Firstname, p.Lastname);
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
