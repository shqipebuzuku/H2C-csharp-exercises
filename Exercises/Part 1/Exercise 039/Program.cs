using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
            int numb = 10;
            int count = 0;
            while (numb != 0)
            {
                Console.WriteLine("Give a number:");
                string i = Console.ReadLine();
                numb = Convert.ToInt32(i);
                if (numb != 0) { count=count+numb; };
                
            };

            Console.WriteLine("Total sum of numbers: " + count);
    }
  }
}
