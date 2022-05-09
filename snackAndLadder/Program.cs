using System;

namespace snakeLadder
{
    class program
    {
        static void Main(string[] args)
        {
            //To Assign the Winnig Player
            int win = 0;

            //Two players
            int[] player = { 0, 0 };
            
            //Dice count for each one
            int [] playerDice = { 0, 0 };

            int rollDice, arrayIndex;
            Random random = new Random();
            string[] choiceArray = { "noPlay", "ladder", "Snake" };
            int turn = 0;
            while (player[0] < 100 && player[1] < 100)
            {
                Console.WriteLine("\nPlayer {0} is playing", (turn + 1));
                Console.WriteLine("player {0} position is: {1}", (turn + 1), player[turn]);

                //Dice rolling logic
                rollDice = random.Next(1, 7);
                playerDice[turn]++;
                Console.WriteLine("Player {0}  dice rolls are: {1}", (turn + 1), playerDice[turn]);
                Console.WriteLine("Number appered on dice is : {0} ", rollDice);

                //Player option Generation "Array" Logic-1
                arrayIndex = random.Next(choiceArray.Length);
                Console.WriteLine("Player option is: {0}", choiceArray[arrayIndex]);

                //Action According to player option
                if (choiceArray[arrayIndex] == "noPlay" && turn == 0)
                {
                    turn = 1;
                    continue;
                }
                else if (choiceArray[arrayIndex] == "noPlay" && turn == 1)
                {
                    turn = 0;
                    continue;
                }
                if (choiceArray[arrayIndex] == "ladder")
                {
                    //If player position goes beyond 100
                    if ((player[turn] + rollDice) >= 100)
                    {
                        player[turn] = 100;
                        win = turn;
                        break;
                    }
                    else
                    {
                        player[turn] += rollDice;
                        continue;
                    }
                }
                else if (choiceArray[arrayIndex] == "snake")
                {
                    //If player position is less than the number appeared on dice
                    if (player[turn] < rollDice)
                    {
                        player[turn] = 0;
                    }
                    else
                    {
                        player[turn] -= rollDice;
                    }
                }

                //If any player reaches to 100
                if (player[0] == 100 || player[1] == 100)
                {
                    win = turn;
                    break;
                }

                //Changing turns
                if (turn == 0)
                {
                    turn = 1;
                }
                else
                {
                    turn = 0;
                }
            }
            Console.WriteLine("Winner Player is : Player {0}",  (win + 1));
            Console.WriteLine("Player position is : {0}",  player[win]);
        }
    }
}