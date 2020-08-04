using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que número deseja somar?");
            int number = Convert.ToInt32(Console.ReadLine());
            int soma = 0;

            while (number >0)
            {
                soma += number % 10;
                number /= 10;
            }

            Console.WriteLine($"A soma dos números é {soma}.");
        }
    }
}
