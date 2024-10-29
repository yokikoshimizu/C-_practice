using System;

namespace VendingMachineSystem
//namespaceという一つの箱を定義（この箱の中に材料と調理の方法を描いていく感じ…？）
{
    class VendingMachine
    //class...設計図（ここに実際の動作のためのプログラムを描く…でOKなのだろうか）
    {
        private const int ProductPrice = 120;
        //ProductPriceを別のclassからアクセスさせないためにprivate
        //const...定数（一度決めたら変更できない数値）←ProductPriceに変動がある場合はconstではなくただのintになる…？

        static void Main(string[] args)
        //よくこの「static void Main(string[] args)」を定型文として覚えることを推奨する書籍があるがなぜ…？
            //プログラムの開始地点（エントリーポイント）として必ず必要。
            //staticは、インスタンスなしで直接呼び出せるために必要。←インスタンスの概念がいまいち理解できない
            //voidは、返り値がないことを示すために必要。←返り値がある場合とない場合の違いがいまいち理解できない
            //string[] argsは、コマンドライン引数を受け取るためのもの。←これは何…？
        {
            Console.WriteLine("お金を投入してください（例: 500）:");
            int inputMoney = int.Parse(Console.ReadLine());
            //Console.ReadLine() はユーザーが入力した情報を取得するためのコード
            //int.Parse は文字として受け取った金額を、整数（int型）に変換する命令

            CalculateChange(inputMoney);
            //ここでCalculateChangeというメソッドを実行するための宣言（呼び出し、inputMoneyの値を引数として渡す）
            //...ということはわかるが、"引数を渡す"という実行がいまいち理解できていない…

            static void CalculateChange(int money)
            //money: 投入金額（計算の元となる値）なので、引数として渡します
            //と、AIが申していたのですが、なぜ計算の元となる値を引数として渡す必要があるのか…？
            {
                if (money >= ProductPrice)
                {
                    int change = money - ProductPrice;
                    //change（お釣り）は、投入金額から商品の価格を引いて計算される値なので、
                    //あらかじめchangeを引数として渡すのではなく、メソッド内で計算する必要がある
                    Console.WriteLine($"おつりは{change}円です");
                }
                else
                {
                    Console.WriteLine("投入金額が不足しています。");
                }
            }
        }
    }
}