using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normal_2_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Если вы  хотите завершить программу, нажимите |0|");
                Console.WriteLine("Введите число : ");
                Console.Write("-> ");

                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0 || num % 3 == 0 && num != 2 && num != 3 && num !=0)
                {
                    Console.WriteLine("||Это составное число||");
                }
                else
                {
                    Console.WriteLine("||Это простое число||");
                }
            } while (num !=0);
                Console.ReadKey();
        }
    }
}
