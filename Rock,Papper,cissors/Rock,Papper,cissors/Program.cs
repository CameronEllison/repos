using System;





namespace Rock_Papper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {


                    Console.Write("Choose bewtween ROCK,PAPER and SCISSORS:       ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(0, 4);
                    
                    switch (randomInt)
                    {
                        case 0:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK!");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!/n/n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player Wins!! /n/n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!/n/n");
                                scoreCPU++;
                            }
                            break;
                        case 1:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPPER!");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!/n/n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Player Wins!! /n/n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!/n/n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS!");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!/n/n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player Wins!! /n/n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!/n/n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!!!");
                }
                else
                {

                }
                Console.WriteLine("Do you want to play again?(y/n)");
                String loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }
            }
        }
    }
}