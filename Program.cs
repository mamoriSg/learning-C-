using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            // Enum (Enumeration)
            Bot bot = new Bot("Bot", 3, new byte[] { 0, 0, 0 }, TypeRobot.Bot);
            Killer killer = new Killer("Bob", 3, new byte[] { 0, 0, 0 }, 10, TypeRobot.Enemy);
      
        }
    }
}

