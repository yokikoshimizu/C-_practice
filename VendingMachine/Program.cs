using System;

namespace VendingMachineSystem
{
    class VendingMachine
    {
        private const int ProductPrice = 120;

        static void Main(string[] args)
        {
            Console.WriteLine("お金を投入してください（例: 500）:");
            int inputMoney = int.Parse(Console.ReadLine());

            CalculateChange(inputMoney);

            static void CalculateChange(int money)
            {
                if (money >= ProductPrice)
                {
                    int change = money - ProductPrice;
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