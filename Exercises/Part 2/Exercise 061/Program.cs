using System;

namespace exercise_61
{
    class Program
    {

        public static void Main(String[] args)
        {
            // Section 1
            PrintSpaces(5);
            Console.WriteLine("");

            // Section 2
            PrintRightTriangle(4);
            Console.WriteLine("");

            // Section 3
            ChristmasTree(10);
            Console.WriteLine("");

        }

        public static void PrintStars(int number1)
        {
            string tabs = new String('*', number1);
            Console.WriteLine(tabs);
            Console.WriteLine("");
        }

        public static void PrintSpaces(int number1)
        {
            string tabs = new String(' ', number1);
            Console.WriteLine(tabs);
            
        }


        public static void PrintRightTriangle(int size)
        {
            int count2 = size;

            for (int count = 1; count <= size; count++)
            {
                count2--;
                string tabs = String.Concat(new String(' ', count2), new String('*', count));
                Console.WriteLine(tabs);

            }

        }
        public static void ChristmasTree(int size)
        {
            int count2 = size;
            int count3 = 0;

            for (int count = 1; count <= size; count++)
            {
                count2--;
                string tabs = String.Concat(new String(' ', count2), new String('*', count+count3));
                Console.WriteLine(tabs);
                count3++;
            }
            string tabs2 = String.Concat(new String(' ', size-2), new String('*', 3));
            Console.WriteLine(tabs2);
            Console.WriteLine(tabs2);
        }
}
