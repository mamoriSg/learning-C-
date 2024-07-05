using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace project
{

    class Program
    {
        static void Main()
        {
            // Try Cathc
            bool isRunning = true;
            while(isRunning){
                try
                {
                    Console.WriteLine("Enter number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    float result = 100 / num;

                    Console.WriteLine("Result: " + result);
                    isRunning = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You enter not a number");
                } catch(DivideByZeroException){
                    Console.WriteLine("Your number is zero");
                } finally {
                    
                }
            }
            

        }
    }
}
