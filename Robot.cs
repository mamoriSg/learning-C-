using System;

namespace project;

abstract class Robot
{
    private string name;
    private short weight;

    private byte[] coordinates;

    public string Name
    {
        get
        {
            return name;
        }
        private set { }
    }

    public short Weight
    {
        get
        {
            Console.WriteLine("Resut : ");
            return this.weight;
        }
        set
        {
            if (value < 1)
                weight = 0;
            else
                this.weight = value;
        }
    }

    public int Width { get; set; }
    public static int count = 0;
    public Robot()
    {
        count++;
    }

    public Robot(string _name)
    {
        name = _name;
        count++;
    }

    public Robot(string _name, short _weight, byte[] _cordinates)
    {
        this.setValues(_name, _weight, _cordinates);
        // this.printValues();
        count++;

    }

    public abstract void Moving(float speed);
    public void setValues(string name, short weight, byte[] cordinates)
    {
        this.name = name;
        this.weight = weight;
        this.coordinates = cordinates;
    }
    public virtual void printValues()
    {
        Console.WriteLine(this.name + ", weight: " + this.weight + ", coordinates: ");
        foreach (byte el in this.coordinates)
            Console.Write(el + " - ");
        Console.WriteLine("");
    }

    public static void Print()
    {
        Console.WriteLine("Count: " + count);
    }
}

