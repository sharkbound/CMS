using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace BombDefuse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print Welcome message
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Welcome to Bomb Defuser (1.0)");

            //Print instructions
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Here you wanna basiclly choose a wire to cut");

            //Print Further instructions
            Console.WriteLine("Understood? Type 'okay' to continune");

            //Change the color
            Console.ForegroundColor = ConsoleColor.DarkGray;

            //Make the user be able to type
            string questionString = Console.ReadLine();

            //Create a randomizer object
            Random RandObj = new Random();

            //If user types "okay" then continue
            if (questionString.ToLower() == "okay")
            {
                //Clear any printed text
                Console.Clear();

                //Reprint Welcome Message
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Welcome to Bomb Defuser (1.0)");

                //Print instructions
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Choose a wire to cut:");

                //Print the available choices
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yellow");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green");

                //Change the color
                Console.ForegroundColor = ConsoleColor.DarkGray;

                //Make the usee be able to type
                Console.ReadLine();
            }


            Console.WriteLine("{0}", RandObj.Next(4) + 1);

            //Create a randomizer object
            Random RandObject = new Random();

            int randNum = RandObject.Next(4);

            switch (randNum)
            {
                case 0:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You cut the wrong wire!!!");
                        Thread.Sleep(1000);
                        break;
                    }

                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You cut the wrong wire!!!");
                        Thread.Sleep(1000);
                        break;
                    }

                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You cut the wrong wire!!!");
                        Thread.Sleep(1000);
                        break;
                    }

                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You cut the correct wire!!!");
                        Console.WriteLine("How many bombs can you defuse?");
                        Thread.Sleep(1000);
                        break;
                    }
            }


            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey();
        }
    }
}
