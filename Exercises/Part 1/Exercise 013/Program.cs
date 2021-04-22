using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // I noticed that in my computer "," was the decimal deparator, so if I input an number with "." it fails
            double num;
            Console.WriteLine("Give a number!");
            string number = Console.ReadLine();
            num = Convert.ToDouble(number);
            Console.WriteLine("You gave "+num);

    }
  }
}
