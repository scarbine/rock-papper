using System;

namespace rock_papper_sissors
{
    class Program
    {
        static void Main(string[] args)

        {

            // Vars

            void Rock()
            {
             Console.WriteLine("Rock");
            }
            void Papper()
            {
             Console.WriteLine("Papper");
            }
            void Scissors()
            {
             Console.WriteLine("Scissors");
            }

            // Function Calls
            Scoreboard(); 
            Rock();
            Papper();
            Scissors();



            // Display Header for the Game

            void Scoreboard()
            {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|  Player: 0    |   Computer: 0");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("What would you like to throw?");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Papper");
            Console.WriteLine("3) Scissors");
            Console.WriteLine("-------------------------------");
            };

            // Accept User input




        }
    }
}
