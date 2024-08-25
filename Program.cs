using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Verificando Se O Numero e Par ou Ímpar");
            do
            {
                Console.Write("Digite o numero: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num <= 0);
            if (num % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");
            Console.WriteLine("\nPressione Enter para sair");
            Console.ReadKey();
        }
    }
}