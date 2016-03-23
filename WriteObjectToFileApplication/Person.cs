/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace WriteObjectToFileApplication
{
    /// <summary>
    /// This class holds Person properties. Class is serialized to write a disk.
    /// </summary>
    [Serializable]
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
