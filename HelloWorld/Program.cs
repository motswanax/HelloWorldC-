using System;
using System.Collections.Generic;
using System.Data.Common;

namespace HelloWorld
{
    class Data
    {
        public string name;
        public int age;
        public string month;

        public void display()
        {
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if (month == "march")
            {
                Console.WriteLine("you are an Aries.");
            }
            else if (month == "april")
            {
                Console.WriteLine("you are a Taurus.");
            }
            else if (month == "may")
            {
                Console.WriteLine("you are a Gemini.");
            }
        }
    }

    class Program
    {
        static public event Action Posted;

        static void Main(string[] args)
        {
            var stats = new Stats();
            stats.Start();

            var data = new Data();
            Console.WriteLine("What is your name?");
            data.name = TryAnswer();

            Console.WriteLine("What is your age?");
            data.age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born in?");
            data.month = TryAnswer();

            // Event triggered.
            if (Posted != null)
                Posted();

            data.display();
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }

    }
}
