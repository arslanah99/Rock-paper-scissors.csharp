namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            Console.WriteLine("Choose between, ROCK, PAPER and SCISSORS:    ");
            inputPlayer = Console.ReadLine();

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);

            switch (randomInt){
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose ROCK!");
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose PAPER!");
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose SCISSORS!");
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }
        }
    }
}
