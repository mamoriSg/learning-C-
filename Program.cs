using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Bot bot = new Bot("Bot Bob", 2, new byte[] { 0, 3, 0 });
            bot.Moving(20f);

            Killer killer = new Killer("Killer", 3, new byte[] { 3, 0, 5 }, 20);
            bot.Moving(25f);

        }
    }
}

