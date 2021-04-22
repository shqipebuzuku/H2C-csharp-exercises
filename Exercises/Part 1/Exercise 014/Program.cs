using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
            Boolean num;
            Console.WriteLine("Give me the truth!");
            string number = Console.ReadLine();
            num = Convert.ToBoolean(number);
            Console.WriteLine("You gave "+num);
    }
  }
}
