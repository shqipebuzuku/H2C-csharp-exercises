using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
            int numb1;
            int abs = 0;

            Console.WriteLine("Give first number:");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);
            if (numb1 < 0) { abs = numb1 * -1; };
            if (numb1 >= 0) { abs = numb1; };

            Console.WriteLine(abs);
      
    }
  }
}
