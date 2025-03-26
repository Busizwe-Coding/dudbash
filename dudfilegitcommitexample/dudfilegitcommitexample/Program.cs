// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    //moved all greetings into void method
    static void allGreetings ()
    {
        string greetings = "Hello world";
        string secondgreetings = "Hello Github!";
        Console.WriteLine(greetings);
        Console.WriteLine(secondgreetings);
    }
    
    static void Main(string[] args)
    {
        //call greetings
        allGreetings();
    }
}

