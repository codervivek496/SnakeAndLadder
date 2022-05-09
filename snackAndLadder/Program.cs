using System;

namespace snakeLadder
{
    class program
    {
        //**Declaring constant for Logic-2**
        public const int noPlay = 0;
        public const int ladder = 1;
        public const int snake = 2;
        static void Main(string[] args)
        {
            int playerPosition = 0, rollDice, playerOption, listIndex;
            Random random = new Random();
            string[] choiceArray = { "noPlay", "ladder", "Snake" };
            while (playerPosition < 100)
            {
                //Dice rolling logic
                rollDice = random.Next(1, 7);
                Console.WriteLine("Number appered on dice is : {0} ", rollDice);

                //Player option Generation "Array" Logic-1
                listIndex = random.Next(choiceArray.Length);
                Console.WriteLine("Player option is: {0}", choiceArray[listIndex]);


                //*******Player options generating "Random" logic-2********
                /*playerOption = random.Next(1, 3);
                switch (playerOption)
                {
                    case noPlay:
                        Console.WriteLine("Player option is : No Play");
                        break;
                    case ladder:
                        Console.WriteLine("Player option is : Ladder");
                        break;
                    case snake:
                        Console.WriteLine("Player Option is : snake");
                        break ;      
                }*/

                //Action according to player option
                if (choiceArray[listIndex] == "ladder")
                {
                    playerPosition += rollDice;
                }
                else if (choiceArray[listIndex] == "snake")
                {
                    if (playerPosition < rollDice)
                    {
                        playerPosition = 0;
                    }
                    else
                    {
                        playerPosition -= rollDice;
                    }
                }
                Console.WriteLine("Player position is : {0}", playerPosition);
            }
            Console.WriteLine("Last player position is: {0}", playerPosition);
        }
    }
}
