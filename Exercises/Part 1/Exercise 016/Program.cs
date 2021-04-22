using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

            int day;
            int secs;
            Console.WriteLine("How many days?");
            string i = Console.ReadLine();
            day = Convert.ToInt32(i);
            secs = day * 24 * 60 * 60;

            Console.WriteLine(day + " days equals " + secs + " seconds");

    }
  }
}
