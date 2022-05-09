using System;

namespace snakeLadder
{
    class program
    {
        static void Main(string[] args)
        {
            int playerPosition = 0, rollDice;
            Console.WriteLine(playerPosition);
            Random random = new Random();
            rollDice = random.Next(1, 7);
            Console.WriteLine("Number appered on dice is {0} ", rollDice);
        }
    }
}
