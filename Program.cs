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
            //ООП
            Robot bot = new Robot();
            bot.Weight = -5;
            bot.Width = 10;
            Console.Write(bot.Weight);
        }
            

        }
}

