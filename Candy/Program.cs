using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Candy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入想吃的糖果數量:");
            var getCandy = Console.ReadLine();
            var WantCandy = int.Parse(getCandy);
            int BuyCandy = 0, Package = 0;
            while (WantCandy > 0)
            {
                BuyCandy++;
                Package++;
                if (Package == 4)
                {
                    BuyCandy--;
                    Package = 1;
                }
                WantCandy--;
            }
            Console.WriteLine("每三張包裝紙可以換一顆糖果，你需要買" + BuyCandy + "顆糖果");
            Console.ReadLine();
        }
    }
}
