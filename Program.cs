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
            Robot bot = new Robot("Bot", 3, new byte[] { 0, 0, 0 });

            Robot killer = new Robot("Killer", 2, new byte[] { 0, 1, 0 });

            Robot robot = new Robot("Alex");

            // Robot.count = 10;

            Robot.Print();
        }
            

        }
}

