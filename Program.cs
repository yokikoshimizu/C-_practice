using System;

enum Hand
{
    Rock, Sissors, Paper
}

namespace janken
{
    class JankenGame
    {
        private static void Main()
        {
            Console.WriteLine("じゃんけんやるで");
            Console.WriteLine("0:グー, 1:チョキ, 2:パー");

            Hand playerHand;
            while (true)
            {
                Console.Write("あなたの手を選んでください (0～2): ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice >= 0 && choice <= 2)
                    {
                        playerHand = (Hand)choice;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("0~2の数字を入力してください");
                    }
                }
                else
                {
                    Console.WriteLine("無効な入力です");
                }
            }

            Random random = new Random();
            Hand computerHand = (Hand)random.Next(0, 3);

            Console.WriteLine("あなたの手:{playerHand}");
            Console.WriteLine("相手の手:{computerHand}");

            if (playerHand == computerHand)
            {
                Console.WriteLine("あいこ！");
            }
            else if
                ((playerHand == Hand.Rock && computerHand == Hand.Sissors) ||
                 (playerHand == Hand.Sissors && computerHand == Hand.Paper) ||
                 (playerHand == Hand.Paper && computerHand == Hand.Rock)
                 )
            {
                Console.WriteLine("おめぇの勝ち");
            }
            else
            {
                Console.WriteLine("おめぇの負け");
            }
        }
    }
}
