using System;

namespace Exercicio_Um
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            var num = int.Parse(Console.ReadLine());

            if (num % 2 == 0 && num >= 0)
                Console.WriteLine("Par positivo");
            else if (num % 2 == 0 && num < 0)
                Console.WriteLine("Par negativo");
            else if (num % 2 != 0 && num >= 0)
                Console.WriteLine("Impar positivo");
            else if (num % 2 != 0 && num < 0)
                Console.WriteLine("Impar negativo");

            Console.ReadKey();
        }
    }
}
