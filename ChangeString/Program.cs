using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string Number = "";
            for (int i = 0; i <= 100; i++)
            {
                Number = i.ToString().Replace('3', 'A').Replace('5', 'B').Replace('9', 'C').Replace('0', 'D');
                Console.WriteLine(Number);
            }
            Console.ReadLine();
        }
    }
}
