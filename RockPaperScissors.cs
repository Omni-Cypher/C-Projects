using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputPlayer = "";
            String  inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int rounds = 0;
            int scoreCPU = 0;
            string answer ="";
            bool loop = true;
            bool wongInput = true;
            Console.Write("Welcome to ROCK PAPER SCISSORS!!!! How many rounds?   ");
            int x = 0;

            while (x == 0)
            {
                try
                {
                    rounds = int.Parse(Console.ReadLine());
                    x++;
                }
                catch( Exception e)
                {
                    Console.WriteLine("Incorrect Input, Enter a NUMBER for the rounds! \n");
                } 
            }
            x = 0; //reset the input loop for next round
            
            while (loop == true)
            {
                answer ="no";
                while (scorePlayer != rounds && scoreCPU != rounds)
                {

                    Console.Write("---------------------------------------------------------\n");
                    Console.Write("Score: \nCPU:" + scoreCPU + "   Player:" + scorePlayer + "\n\n");
                    Console.Write("Chose between ROCK, PAPER, and SCISSORS:     ");
                    while (wongInput == true)
                    {
                        inputPlayer = Console.ReadLine();
                        if ((inputPlayer == "rock" || inputPlayer == "ROCK") ||
                            (inputPlayer == "paper" || inputPlayer == "PAPER") ||
                            (inputPlayer == "scissors" || inputPlayer == "SCISSORS") )
                        {
                            wongInput = false;
                        }
                        else
                        {
                            Console.WriteLine("thanks not a valid choice, try again\n");
                            Console.Write("Chose between ROCK, PAPER, and SCISSORS:     ");
                        }
                    }
                    wongInput = true;


                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK" || inputPlayer == "rock")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Draw!!!\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (inputPlayer == "PAPER" || inputPlayer == "paper")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Player gets a point!\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                scorePlayer++;
                            }
                            if (inputPlayer == "SCISSORS" || inputPlayer == "scissors")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Computer gets a point!\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "ROCK" || inputPlayer == "rock")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Computer gets a point!\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                scoreCPU++;
                            }
                            if (inputPlayer == "PAPER" || inputPlayer == "paper")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Draw!!!\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (inputPlayer == "SCISSORS" || inputPlayer == "scissors")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Player gets a point!\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "ROCK" || inputPlayer == "rock")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Player gets a point!\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                scorePlayer++;
                            }
                            if (inputPlayer == "PAPER" || inputPlayer == "paper")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Computer gets a point!\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                scoreCPU++;
                            }
                            if (inputPlayer == "SCISSORS" || inputPlayer == "scissors")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Draw!!!\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        default:
                            break;
                    }
                }

                Console.Write("---------------------------------------------------------\n");
                Console.Write("Score: \nCPU:" + scoreCPU + "   Player:" + scorePlayer + "\n\n");

                if (scorePlayer > scoreCPU)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PLAYER WINS!!!!!! :D , thanks for playing");
                    Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("COMPUTER WINS!!!!!! >:), thanks for playing");
                    Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("Would you like to play again?");

                    answer = Console.ReadLine();
                 if (answer == "yes" || answer == "YES" || answer == "y")
                 {
                            loop = true;
                            scoreCPU = 0;
                            scorePlayer = 0;
                   
                 }
                 else
                 {
                            loop = false;
                            Console.WriteLine("Bye bye !");
                            Console.WriteLine();
                 }
            }//gamecount loop      
        }// game again? loop
     }
 }
    

