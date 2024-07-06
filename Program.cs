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
            bot.setValues("Bot", 3, new byte[] { 0, 0, 0 });

            Robot killer = new Robot();
            killer.setValues("Killer", 2, new byte[] { 0, 1, 0 });

            bot.printValues();
            killer.printValues();
        }
            

        }
}

