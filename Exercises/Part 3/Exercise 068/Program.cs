using System;
using System.Collections.Generic;

namespace exercise_68
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
            for(int count = 0;count < num; count++) { Console.WriteLine(list[count]); }
        }
    }
}
