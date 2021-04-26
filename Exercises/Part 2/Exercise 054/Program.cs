using System;

namespace exercise_54
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1;
            int numb2;
            
            Console.WriteLine("Give start");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);

            Console.WriteLine("Give end");
            string j = Console.ReadLine();
            numb2 = Convert.ToInt32(j);

            DivisibleByThreeInRange(numb1,numb2); 
            
        }
        public static void DivisibleByThreeInRange(int beginning, int end)
        {

            for (; beginning <= end; beginning++)
            {
                if((beginning%3) == 0) { Console.WriteLine(beginning); }
            }
                    
        }
    }
}
