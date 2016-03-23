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
    /// Own made CarException class.
    /// </summary>
    class CarException : Exception
    {
        public CarException(string message) : base(message)
        {

        }
    }
}
