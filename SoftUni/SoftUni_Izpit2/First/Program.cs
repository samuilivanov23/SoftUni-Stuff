using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal currentBitCoinValue = decimal.Parse(Console.ReadLine());
            decimal currentEtereumValue = decimal.Parse(Console.ReadLine());
            decimal currentLitcoinValue = decimal.Parse(Console.ReadLine());
            int numberTranzactions = int.Parse(Console.ReadLine());

            int countOfBurOrSell = 0;
            string typeOfCrypto = "";
            string typeOfAction = "";

            decimal commisionValue = 0.073456764216789345m;
            decimal sumOfComisions = 0 ;
            decimal sumOfBitCoins = 0;
            decimal sumOfLiteCoins = 0;
            decimal sumOfEthereums = 0;
            decimal result = 0;
            decimal LocalSum = 0;

            for(int i = 0; i < numberTranzactions; i++)
            {
                countOfBurOrSell = int.Parse(Console.ReadLine());
                typeOfCrypto = Console.ReadLine();
                typeOfAction = Console.ReadLine();
                if(typeOfCrypto == "Bitcoin")
                {
                    LocalSum = countOfBurOrSell * currentBitCoinValue;
                   // Console.WriteLine(LocalSum);
                    sumOfComisions += LocalSum * commisionValue;
                    //Console.WriteLine(sumOfComisions);

                    if (typeOfAction == "Buy")
                    {
                        result += LocalSum;
                        result -= sumOfComisions;
                    }
                    else
                    {
                        result -= LocalSum;
                        result -= sumOfComisions;
                    }
                }
                else if(typeOfCrypto == "Litecoin")
                {
                    LocalSum = countOfBurOrSell * currentLitcoinValue;
                    sumOfComisions += LocalSum * commisionValue;
                    //Console.WriteLine(LocalSum);
                    //Console.WriteLine(sumOfComisions);


                    if (typeOfAction == "Buy")
                    {
                        result += LocalSum;
                        result -= sumOfComisions;
                    }
                    else
                    {
                        result -= LocalSum;
                        result -= sumOfComisions;
                    }

                }
                else if(typeOfCrypto == "Ethereum")
                {
                    LocalSum = countOfBurOrSell * currentEtereumValue;
                    sumOfComisions += LocalSum * commisionValue;
                    //Console.WriteLine(LocalSum);
                   // Console.WriteLine(sumOfComisions);


                    if (typeOfAction == "Buy")
                    {
                        result += LocalSum;
                        result -= sumOfComisions;
                    }
                    else
                    {
                        result -= LocalSum;
                        result -= sumOfComisions;
                    }
                }
                sumOfComisions = 0;
            }

            //Console.WriteLine(result.ToString("0.0000000000000000"));
            Console.WriteLine(result);

        }
    }
}
