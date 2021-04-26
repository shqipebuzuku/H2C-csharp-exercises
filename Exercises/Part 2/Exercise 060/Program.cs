using System;

namespace exercise_60
{
    class Program
    {

        public static void Main(String[] args)
        {
            // Section 1
            PrintStars(5);
            PrintStars(3);
            PrintStars(9);

            // Section 2
            PrintSquare(4);

            // Section 3
            PrintRectangle(17, 3);

            // Section 3
            PrintTriangle(4);
        }

        public static void PrintStars(int number1)
        {
            string tabs = new String('*', number1);
            Console.WriteLine(tabs);
            Console.WriteLine("");
        }

        public static void PrintSquare(int number1)
        {
            
            string tabs = new String('*', number1);
            for(int count = 1;count <= number1; count++) { Console.WriteLine(tabs); }

            Console.WriteLine("");

        }
        public static void PrintRectangle(int width, int height)
        {

            string tabs = new String('*', width);
            for (int count = 1; count <= height; count++) { Console.WriteLine(tabs); }

            Console.WriteLine("");

        }

        public static void PrintTriangle(int size)
        {

            
            for (int count = 1; count <= size; count++) { PrintStars(count); }

            Console.WriteLine("");

        }
    }
}
