using System;
using System.Collections.Generic;

namespace project
{
    class Program
    {
        static void Main()
        {
            Robot bot = new Robot("Bot");
            Robot killer = new Killer("Killer", 3, new byte[] {0,0,0}, 10);

            List<Robot> robots = new List<Robot>();
            robots.Add(bot);
            robots.Add(killer);
            robots.Add(new Robot("ALex"));

            Killer killer1 = null;
            foreach(Robot el in robots)
            {
                if(el.Name == "Killer"){
                    killer1 = el as Killer;
                    killer1.Lazer();
                }
                Console.WriteLine(el is Killer);
            }
        }
        }
}

