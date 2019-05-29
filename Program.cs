namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            System.Console.WriteLine("Choose between, ROCK, PAPER and SCISSORS:    ");
            inputPlayer = System.Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            System.Random rnd = new System.Random();

            randomInt = rnd.Next(1, 4);

            switch (randomInt){
                case 1:
                    inputCPU = "ROCK";
                    System.Console.WriteLine("Computer chose ROCK!");
                    if(inputPlayer == "ROCK"){
                        System.Console.WriteLine("DRAW!!!!!\n\n");
                    } else if (inputPlayer == "PAPER"){
                        System.Console.WriteLine("PLAYER WINS!!!!\n\n");
                        scorePlayer++;
                    } else if(inputPlayer == "SCISSORS"){
                        System.Console.WriteLine("CPU WINS!!!!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    System.Console.WriteLine("Computer chose PAPER!");
                    if(inputPlayer == "PAPER"){
                        System.Console.WriteLine("DRAW!!!!!\n\n");
                    } else if (inputPlayer == "SCISSORS"){
                        System.Console.WriteLine("PLAYER WINS!!!!\n\n");
                        scorePlayer++;
                    } else if(inputPlayer == "ROCK"){
                        System.Console.WriteLine("CPU WINS!!!!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    System.Console.WriteLine("Computer chose SCISSORS!");

                    if(inputPlayer == "SCISSORS"){
                        System.Console.WriteLine("DRAW!!!!!\n\n");
                    } else if (inputPlayer == "PAPER"){
                        System.Console.WriteLine("PLAYER WINS!!!!\n\n");
                        scorePlayer++;
                    } else if(inputPlayer == "ROCK"){
                        System.Console.WriteLine("CPU WINS!!!!!\n\n");
                        scoreCPU++;
                    }
                    break;
                default:
                    System.Console.WriteLine("Invalid entry");
                    break;
            }
        }
    }
}
