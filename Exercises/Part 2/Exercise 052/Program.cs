using System;

namespace exercise_52
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1;
            
            Console.WriteLine("What number?");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);

            PrintFromNumberToOne(numb1); 
            
        }
        public static void PrintFromNumberToOne(int a)
        {
            int count;
            for (count = 1; count <= a; a--) {  
            Console.WriteLine(a);
            };
        }
    }
}
}
