using System;

namespace rock_papper_sissors
{
    class Program
    {
        static void Main(string[] args)

        {

            // Vars

            int HumanScore = 0;
            int ComputerScore = 0;
            string ComputerChoice = "";
            string[] computer = {"1" , "2" , "3"};

            void Rock()
            {
                Console.WriteLine(@"
                    _______
                ---'   ____)
                     (_____)
                     (_____)
                      (____)
                ---.__(___)
                ROCK
                ");
            }
            void Papper()
            {
                Console.WriteLine(@"
                    _________
                ---'      ____)____
                              ______)
                             _______)
                           _______)
                ---.__________)
                PAPPER
                ");
            }
            void Scissors()
            {
                Console.WriteLine(@"
                    _______
                ---'    ____)____
                            ______)
                        __________)
                      (____)
                ---.__(___)
                SCISSORS
                ");
            }

            // Function Calls
            Scoreboard(HumanScore, ComputerScore);
         


            // Display Header for the Game

            void Scoreboard(int HumanScore, int ComputerScore)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"|  Player: {HumanScore}    |   Computer: {ComputerScore}");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("What would you like to throw?");
                Console.WriteLine("1) Rock");
                Console.WriteLine("2) Papper");
                Console.WriteLine("3) Scissors");
                Console.WriteLine("-------------------------------");
            // Accept User input
                string userChoice = Console.ReadLine();
                GenerateComputerChoice();
                DisplayHumanChoice(userChoice);
                Console.WriteLine("vs");
                DisplayComputerChoice(ComputerChoice);
                
            };

                void GenerateComputerChoice()
                {
                    Random r =new Random();
                    int genRan = r.Next(0,3);
                    ComputerChoice = computer[genRan];
                    
                }


                void DisplayHumanChoice(string userChoice)
                {
                    if(userChoice == "1")
                    {
                        Rock();
                    }
                    else if (userChoice == "2")
                    {
                        Papper();
                    }
                    else
                    {
                        Scissors();
                    }

                }
                void DisplayComputerChoice(string ComputerChoice)
                {
                    if(ComputerChoice == "1")
                    {
                        Rock();
                    }
                    else if (ComputerChoice == "2")
                    {
                        Papper();
                    }
                    else
                    {
                        Scissors();
                    }

                }




        }
    }
}
