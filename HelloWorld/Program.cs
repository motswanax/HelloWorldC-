using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("What month were you born in?");
            var birthMonth = Console.ReadLine();
         
            Console.WriteLine($"Hi {name}. You are {age} years old and born in {birthMonth}");

            if(birthMonth == "march")
            {
                Console.WriteLine("You are an Aries");
            } else if(birthMonth == "april")
            {
                Console.WriteLine("You are a Taurus");
            }
            else if (birthMonth == "may")
            {
                Console.WriteLine("You are a Gemini");
            }
        }
    }
}
