namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while(playAgain){
            int scorePlayer = 0;
            int scoreCPU = 0;

            while(scorePlayer < 3 && scoreCPU < 3){


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
                        System.Console.WriteLine("CPU WINS!!!!\n\n");
                        scoreCPU++;
                    } else if(inputPlayer == "ROCK"){
                        System.Console.WriteLine("PLAYER WINS!!!!!\n\n");
                        scorePlayer++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    System.Console.WriteLine("Computer chose SCISSORS!");

                    if(inputPlayer == "SCISSORS"){
                        System.Console.WriteLine("DRAW!!!!!\n\n");
                    } else if (inputPlayer == "PAPER"){
                        System.Console.WriteLine("CPU WINS!!!!\n\n");
                        scoreCPU++;
                    } else if(inputPlayer == "ROCK"){
                        System.Console.WriteLine("PLAYER WINS!!!!!\n\n");
                        scorePlayer++;
                    }
                    break;
                default:
                    System.Console.WriteLine("Invalid entry");
                    break;
            }
        }
        if(scorePlayer == 3){
            System.Console.WriteLine("PLAYER WON!");
        } else if(scoreCPU == 3){
            System.Console.WriteLine("CPU WON!");
        } else{

        }
        System.Console.WriteLine("Do you want to play again?(y/n)");
        string loop = System.Console.ReadLine();
        if(loop == "y"){
            playAgain = true;
                    } else if(loop == "n"){
                        playAgain = false;
                    } else if(loop != "n" || loop != "y") {
                        System.Console.WriteLine("Invalid Entry please start game again!");
                        playAgain = false;
                    }
            }
        }
    }
}
