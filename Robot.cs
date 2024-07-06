using System;

namespace project;

class Robot 
{
    private string name;
    private short weight;

    private byte[] coordinates;

    public void setValues(string _name, short _weight, byte[] _cordinates){
        name = _name;
        weight = _weight;
        coordinates = _cordinates;
    }
    public void printValues(){
        Console.WriteLine(name + ", weight" + weight + ", coordinates: ");
        foreach (byte el in coordinates)
            Console.Write(el + " - ");
        Console.WriteLine("");
    }
}