using System;
using System.Net;

namespace project;
class Bot : Robot, IRun
{
    public float SpeedRun { get; set; }
    public Bot()
    {
    }
    public Bot(string name, short weight, byte[] cordinates) : base(name, weight, cordinates) { }

    public void RobotRun()
    {
        Console.WriteLine("Bot is running: " + SpeedRun);
    }
    public override void Moving(float speed)
    {
        Console.WriteLine("Killer is Moving: " + speed);
    }
}