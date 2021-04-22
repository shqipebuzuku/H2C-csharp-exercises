using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
            int num;
            Console.WriteLine("Give a number!");
            string number = Console.ReadLine();
            num = Convert.ToInt32(number);
            Console.WriteLine("You gave "+num);

    }
  }
}
