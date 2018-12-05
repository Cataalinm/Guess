using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMe
{
    class Program
    {
        static void GuessMe()
        {

            int number;
            int x;
            Random nr = new Random();
            string choice;
            int ok = 1;

            x = nr.Next(0, 100);
            Console.WriteLine();
            Console.WriteLine("Press any key to start the game");
            Console.ReadKey();

            while (ok == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter your number: ");
                choice = Console.ReadLine();
                Int32.TryParse(choice, out number);
                if (number == x)
                {
                    Console.WriteLine("Gratz! You guessed the number!");
                    return;
                }
                else
                    if (number > x)
                    Console.WriteLine("The number is too large! Try once again");
                else
                    Console.WriteLine("The number is too low! Try once again");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("        Welcome to the GuessMe game.");
            Console.WriteLine("     There are only a few simple rules.");
            Console.WriteLine("1) You have to guess a randomly generated number - the game will stop when you get it right!");
            Console.WriteLine("2) Everytime you enter a wrong number, a clue will be provided - if your number is too large or too low.");
            Console.WriteLine("3) You can play until you guess it and then start again!");

            string ok = "1";
            while (ok == "1")
            {
                GuessMe();
                Console.WriteLine();
                Console.WriteLine("Doriti sa mai jucati odata? ");
                Console.WriteLine("1 -- Da      2 -- Nu");
                ok = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
