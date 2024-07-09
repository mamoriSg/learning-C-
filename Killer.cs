using System;

namespace project;

class Killer : Robot
{
    public int Damage { get; private set; }

    public Killer(){}

    public Killer(string name, short weight, byte[] cordinates, int damage) : base(name, weight, cordinates){
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
}