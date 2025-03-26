// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
    class dudFile()
    {
        //methods cannot be overriden only classes
        //create class no meaning
        //add virtual void and add formatting
        class noMeaning
        {
            public virtual void meaning(string meaningless)
            {
                Console.WriteLine("Here we have no meaning: "+ meaningless);
            }
        }
        //Override noMeaning
        //use the exact same skeleton
        class dudWords:noMeaning
        {
            public virtual void meaning(string meaningless)
            {
                Console.WriteLine("Here we have worthless: "+ meaningless);
            }
        }

        //moved all greetings into void method
        static void allGreetings()
        {
            string greetings = "Hello world";
            string secondgreetings = "Hello Github!";
            Console.WriteLine(greetings);
            Console.WriteLine(secondgreetings);
        }
        static void Main()
        {
            //call greetings
            allGreetings();

            //call and initialize inheritance examples
            noMeaning baseClass = new noMeaning();
            dudWords childClass = new dudWords();

            baseClass.meaning("fghj");
            childClass.meaning("A dud file.");
        }
    }
    
}

