using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
            int numb1;
            int count;
            Console.WriteLine("How many times?");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);
            for(count = 0;count < numb1;count++) { PrintPhrase(); };
 
    }

    // Write your method here:
    public static void PrintPhrase() {
            Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}
