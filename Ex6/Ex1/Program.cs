using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número: ");
            Int32 n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("O número é par.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("O número é impar.");
                Console.ReadKey();
            }
        }
    }
}
