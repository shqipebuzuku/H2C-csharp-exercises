using System;
using System.Collections.Generic;

namespace exercise_83
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a word: ");
            string word = Console.ReadLine() ;
            word = word + word + word;
            Console.WriteLine(word);
        }

    }
}

