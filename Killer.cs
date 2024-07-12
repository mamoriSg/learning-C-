using System;

namespace project;

class Killer : Robot, IFly
{
    public int Damage { get; private set; }

    public Killer() { }

    public Killer(string name, short weight, byte[] cordinates, int damage, TypeRobot type) : base(name, weight, cordinates, type)
    {
        this.Damage = damage;
        // base.printValues();
    }

    public override void printValues()
    {
        base.printValues();
        Console.WriteLine("Damage: " + Damage);
    }
    public void Lazer()
    {
        Console.Write("Lazer is shooting");
    }

    public override void Moving(float speed)
    {
        Console.WriteLine("Killer is jumping: " + speed);
    }

    public void RobotFly(int maxheigh)
    {

    }
}