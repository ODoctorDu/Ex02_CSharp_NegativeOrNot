using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3p2EstruturaCondicional
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.\n");
            Console.WriteLine("Vou testar se seu número é negativo.");
            Console.Write("Digite o valor: ");
            double valor = double.Parse(Console.ReadLine());

            if(valor >= 0)
            {
                Console.Write("O Número " + valor + " é positivo.");
            }
            else
            {
                Console.Write("O Número " + valor + " é negativo.");
            }

            Console.ReadKey();

        }
    }
}
