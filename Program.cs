using System;

namespace HowManyDiapersCanYouBuy
{
    class Program
    {
        static void Main(string[] args)
        {
            //How many packages of diapers can you buy with \$40 if one package costs 8?

            int diapers = 8;
            int moneyInWallet = 40;
            int packagesOfDiapers = moneyInWallet / diapers;
            Console.WriteLine("You have enough money to buy " + packagesOfDiapers + " packages of diapers.");
        }
    }
}
