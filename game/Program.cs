using System;
using System.Diagnostics.Tracing;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("What`s your name?");
            string name;
            name = Console.ReadLine();
            int computerScore = 0;
            int userScore =0;        
            Console.WriteLine("Hello," + name);
            while(computerScore<3 && userScore<3)
            {
            Console.WriteLine("Do you choose rock,paper or scissors");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(4);

            if (computerChoice == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("It is a tie ");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose rock");
                        userScore++;
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose rock");
                        computerScore++;
                }
                else
                {
                    Console.WriteLine("this is not a choice");
                }
            }
            else if (computerChoice == 2)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose paper");
                        computerScore++;
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose paper");
                       Console.WriteLine("tie");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose paper");
                     userScore++;
                }
                else
                {
                    Console.WriteLine("this is not a choice");
                }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose scissors");
                        userScore++;
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose scissors");
                    computerScore++;
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("tie");
                }
                else
                {
                    Console.WriteLine("this is not a choice");
                }
            }
                
            }
                if (computerScore == 3)
                {
                    Console.WriteLine("computer wins!");

                }
                else
                {
                    Console.WriteLine("You win!");
                }
        }
    }
    }
     
