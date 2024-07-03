using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace project
{

    class Program
    {
        static void Main()
        {
            // Практика функції
            byte[] nums1 = { 5, 7, 8 };
            int summa1 = Summa(nums1);

            byte[] nums2 = { 5, 7, 8, 9 ,20 };
            int summa2 = Summa(nums2);

            if (summa1 > summa2)
                Console.WriteLine("Max: " + summa1);
            else
                Console.WriteLine("Max: " + summa2);

        }

        public static int Summa (byte[] digits){
            byte[] nums1 = { 5, 7, 8 };
            int summa = 0;
            foreach (byte el in digits)
            {
                summa += el;
            }
            // Console.WriteLine("Result: " + summa);
            return summa;
        }

    }

}

