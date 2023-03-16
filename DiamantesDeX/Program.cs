using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamantesDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número ímpar: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("O número digitado não é ímpar.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(n / 2 - i) + Math.Abs(n / 2 - j) <= n / 2)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
