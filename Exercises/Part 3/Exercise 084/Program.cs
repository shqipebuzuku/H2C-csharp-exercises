﻿using System;
using System.Collections.Generic;

namespace exercise_84
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Give a string");
            string word = Console.ReadLine();

            if (word == "true") { Console.WriteLine("You got it right!"); }
            if (word != "true") { Console.WriteLine("Try again!"); }
        }
    }
}

