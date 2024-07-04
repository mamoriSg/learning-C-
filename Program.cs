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
            // // Робота з файлами
            // Console.WriteLine("Enter text: ");
            // string text = Console.ReadLine();
            // using(FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate)){
            //     byte[] array = System.Text.Encoding.Default.GetBytes(text);
            //     stream.Write(array);
            // }

            using(FileStream stream = File.OpenRead("info.txt")){
                byte[] array = new byte[stream.Length];
                stream.Read(array);

                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(textFromFile);
            }

        }
    }
}
