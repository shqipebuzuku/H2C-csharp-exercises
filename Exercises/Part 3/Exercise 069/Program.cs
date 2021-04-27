using System;
using System.Collections.Generic;

namespace exercise_69
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }
            int num = list.Count;
            
            Console.WriteLine("From where?");
            int low = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("To where?");
            int high = Convert.ToInt32(Console.ReadLine());
            for (int count = 0;count < num; count++) 
            { 
                if (list[count]>=low && list[count] <= high) { Console.WriteLine(list[count]); }
                
            }
        }
    }
}
