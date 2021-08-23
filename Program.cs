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
            string[] computer = { "1", "2", "3" };
            string userChoice = "";

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

            while ((HumanScore < 3) && (ComputerScore < 3))
            {
                Display();
            }

            EndGame();


            // Randomly select a choice for the computer
            void GenerateComputerChoice()
            {
                Random r = new Random();
                int genRan = r.Next(0, 3);
                ComputerChoice = computer[genRan];

            }

            // Display Header for the Game
            void Display()
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"|  Human: {HumanScore}    |   Computer: {ComputerScore}");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("What would you like to throw?");
                Console.WriteLine("1) Rock");
                Console.WriteLine("2) Papper");
                Console.WriteLine("3) Scissors");
                // Console.WriteLine("-------------------------------");
                userChoice = Console.ReadLine();
                GenerateComputerChoice();

                GameResults(HumanScore, ComputerScore);
            }



            void GameResults(int humanScore, int computerScore)
            {

                DisplayHumanChoice(userChoice);
                Console.WriteLine("vs");
                DisplayComputerChoice(ComputerChoice);
                if ((userChoice == "1" && ComputerChoice == "3") || (userChoice == "2" && ComputerChoice == "1") || (userChoice == "3" && ComputerChoice == "2"))
                {
                    HumanScore = humanScore + 1;
                    Console.Write("Human wins this round.");
                }
                else if (userChoice == ComputerChoice)
                {
                    Console.Write("This round was a tie.");
                }
                else
                {
                    ComputerScore = computerScore + 1;
                    Console.Write("Computer wins this round.");
                }


            };

            void EndGame()
            {
                if (HumanScore < ComputerScore)
                {
                    Console.WriteLine("AI Takeover!");
                }
                else
                {
                    Console.WriteLine("Somehow the human escaped alive...");
                }
            }

            void DisplayHumanChoice(string userChoice)
            {
                if (userChoice == "1")
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
                if (ComputerChoice == "1")
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

