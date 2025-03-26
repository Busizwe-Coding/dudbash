// See https://aka.ms/new-console-template for more information
using System;
class colour
{
    public virtual void showColour(string colourPicked)
    {
        Console.WriteLine("The base colour will be: "+colourPicked);
    }
}
class otherColour : colour
{
    public override void showColour(string colourPicked)
    {
        Console.WriteLine("Ther undertone will be: "+colourPicked);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("For this painting...");

        colour mainColour = new colour();
        mainColour.showColour("Red");

        otherColour newColour = new otherColour();  
        newColour.showColour("Brown");
    }
}
