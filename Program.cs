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
                Console.WriteLine(@"
                    _______
                ---'   ____)
                    (_____)
                    (_____)
                    (____)
                ---.__(___)
                ");
            }
            void Papper()
            {
                Console.WriteLine(@"
                    _______
                ---'    ____)____
                        ______)
                        _______)
                        _______)
                ---.__________)
                ");
            }
            void Scissors()
            {
                Console.WriteLine(@"
                  _______
                ---'   ____)____
                        ______)
                    __________)
                    (____)
                ---.__(___)
                ");
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
