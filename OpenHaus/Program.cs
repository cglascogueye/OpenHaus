using System;

namespace OpenHaus
{
    class Program
    {
        private const string V = "White House";

        static void HausLog(TinyHaus userInput)
        {
            //method added by CJ
            Console.WriteLine("What would you like to know?\n*enter command*:   'price' 'rooms' 'end'");
            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input == "price")
                    Console.WriteLine($"A house like this can go anywhere from {userInput.PricePointLow} to {userInput.PricePointHigh}");
                if (input == "rooms")
                    Console.WriteLine($"This house has {userInput.NumRooms} rooms");
                else
                    Console.WriteLine("*please enter valid command*");
                Console.WriteLine("What would you like to know?\n*enter command*:   'price' 'rooms' 'end'");
                input = Console.ReadLine();

            }
            return;


        }
        static void Main(string[] args)
        {
            //added starting code by CJ
            //***TODO***
            //  1. Create three instances of TinyHaus to get a tours    *1/3*
            //  2. Create method HausLog that will tell user the properties about each house    *0/1*
            //  3. Allow user input to choose which house they want to tour *0/1*
            //  4. Allow user to tour houses until satisfied    *0/1*
            Console.WriteLine("Welcome, welcome! Which property would you like to see?");

            TinyHaus White = new TinyHaus
            {
                HausName = "White House",
                HausColor = "White",
                PricePointLow = 30000.00,
                PricePointHigh = 60000.00,
                NumRooms = 5
            };

            HausLog(White);
        }
    }
}
