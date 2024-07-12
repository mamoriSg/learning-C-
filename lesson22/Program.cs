using System;

namespace project
{

    class Program
    {
        static void Main()
        {
            //Перевантаження методів
            Multiply(5.4f, 8.6f);
        }

        public static void Multiply(int a, int b)
        {
            int res = a * b;
            Console.WriteLine("Result: " + res);
        }
        public static void Multiply(int a, int b, int c)
        {
            int res = a * b * c;
            Console.WriteLine("Result: " + res);
        }
        public static void Multiply(float a, float b)
        {
            float res = a * b;
            Console.WriteLine("Result: " + res);
        }
    }
}