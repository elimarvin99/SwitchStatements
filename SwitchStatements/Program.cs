using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject: math, science, history, grammar, social studies?");
            Console.WriteLine("Your answer must be typed exactly as it is displayed above");
            //figure out how to change input to lower or upper case that way we don't run into this problem
            var userInput = Console.ReadLine();



            switch (userInput.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is Awesome");
                    break;
                case "science":
                    Console.WriteLine("Science is a horrible subject");
                    break;
                case "history":
                    Console.WriteLine("What's prolouge is present");
                    break;
                case "grammar":
                    Console.WriteLine("A bunch of boring rules");
                    break;
                case "social studies":
                    Console.WriteLine("I rather recess");
                    break;
                default:
                    Console.WriteLine("You have not picked a valid subject. Automatic Detention");
                    break;

            }
        }
    }
}
