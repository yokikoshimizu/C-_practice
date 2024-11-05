using System;

namespace Janken
{
    class Program
    {
        enum Hand { グー, チョキ, パー }

        static void Main()
        {
            Console.WriteLine("じゃんけんするで");
            Console.WriteLine("0:グー, 1:チョキ, 2:パー");

            //プレイヤーの手
            Console.Write("最初はグー！じゃんけん…");
            int playerChoice = int.Parse(Console.ReadLine());

            //入力値のチェック
            if (playerChoice < 0 || playerChoice > 2)
            {
                Console.WriteLine("無効な入力です");
                return;
                //なぜここはreturnで返す必要がある？voidがあるのでは？
            }
          

            Hand playerHand = (Hand)playerChoice;
            //playerHandはもともとintなので0~2しか入らないから、"グー、チョキ、パー"は出力されるようにキャストするための処理がこのコード？

            //コンピューターの手
            Random random = new Random();
            //Randomは型ではない？Handと同じ扱い？？
            //randomの新しい個体を生むためにnewを付けている？（ならなぜRandom()なの？）

            Hand computerHand = (Hand)random.Next(0,3);
            //randomで生成されるのが整数だからキャストする？
            //random.Next(数字)は決まった文法のようなもの？

            //手の出力
            Console.WriteLine($"コンピューター：{computerHand}　あなた： {playerHand}");

            //勝敗
            string result = "";
            //なぜ初期化が必要？
            if(playerHand == computerHand)
            {
                Console.WriteLine("あいこ");
            }
            else if((playerHand == Hand.グー && computerHand == Hand.チョキ) 
                || (playerHand == Hand.チョキ && computerHand == Hand.パー)
                || (playerHand == Hand.パー && computerHand == Hand.グー))
            {
                Console.WriteLine("勝ち！");
            }
            else
            {
                Console.WriteLine("はい負けー");
            }

            //結果の表示
            Console.WriteLine(result);

        }
    }
}