using System;
using System.Net;

namespace project;
class Bot : Robot
{
    public Bot()
    {
    }
    public Bot(string name, short weight, byte[] cordinates) : base(name, weight, cordinates) { }

    public override void Moving(float speed)
    {
        Console.WriteLine("Killer is Moving: " + speed);
    }
}