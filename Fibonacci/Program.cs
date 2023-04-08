using System;

namespace Fibonacci
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número e descubra se ele pertence a sequência de Fibonacci:");
            int num = int.Parse(Console.ReadLine());
            int a = 0, b = 1;

            while (b < num)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            if (num == b)
            {
                Console.WriteLine(num + " pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine(num + " não pertence à sequência de Fibonacci.");
            }

        }
    }
}