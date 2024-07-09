using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Killer killer = new Killer("Killer", 3, new byte[] {3, 0, 5}, 20);
            killer.printValues();
        }
        }
}

