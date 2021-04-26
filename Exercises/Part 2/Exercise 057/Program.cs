using System;

namespace exercise_57
{
    class Program
    {

        public static void Main(String[] args)
        {
            int numb1;
            int numb2;
            int numb3;
            int numb4;

            Console.WriteLine("Give number");
            string i = Console.ReadLine();
            numb1 = Convert.ToInt32(i);

            Console.WriteLine("Give number");
            string j = Console.ReadLine();
            numb2 = Convert.ToInt32(j);

            Console.WriteLine("Give number");
            string k = Console.ReadLine();
            numb3 = Convert.ToInt32(k);

            Console.WriteLine("Give number");
            string l = Console.ReadLine();
            numb4 = Convert.ToInt32(l);


            int answer = Sum(numb1, numb2, numb3, numb4);
            Console.WriteLine("Sum: " + answer);
        }

        public static int Sum(int number1, int number2, int number3, int number4)
        {
            int result;
            result = number1 + number2 + number3 + number4;
            return result;

        }

    }
}
