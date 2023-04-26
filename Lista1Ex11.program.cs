using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Realizando: Operação ('X' elevado a 'Y'):");
            Console.Write("Digite o valor de X:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y:");
            b = double.Parse(Console.ReadLine());

            c = Math.Pow(a, b);
            Console.WriteLine($"A Operação 'X' ({a}) elevado a 'Y' ({b}) resultou em {c}.");

        }
    }
}
