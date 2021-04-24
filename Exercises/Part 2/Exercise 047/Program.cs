using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
            // Section 1
            Console.WriteLine("Section 1");
            int numb1;
            int count = 1;

            Console.WriteLine("Where to?");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);

            while (count <= numb1) { Console.WriteLine(count); count++; };

            // Section 2
            Console.WriteLine("Section 2");
            int numb2;
            int numb3;

            Console.WriteLine("Where to?");
            string j = Console.ReadLine();
            numb2 = Convert.ToInt32(j);

            Console.WriteLine("Where from?");
            string k = Console.ReadLine();
            numb3 = Convert.ToInt32(k);

            while (numb3 <= numb2) { Console.WriteLine(numb3); numb3++; };
    }
  }
}
