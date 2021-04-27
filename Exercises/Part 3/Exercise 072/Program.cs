using System;
using System.Collections.Generic;

namespace exercise_72
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 9999)
                {
                    break;
                }
                list.Add(input);
            }
            int num = list.Count;
            
            int min = 9999;
            
            for (int count = 0;count < num; count++) 
            {
                if (list[count] <= min) { min = list[count]; }
                
            }
            Console.WriteLine("Smallest number: " + min);
            for (int count = 0; count < num; count++) 
            { 
                if(list[count] == min) { Console.WriteLine("Found at index: " + count); }
            }
        }
    }
}
