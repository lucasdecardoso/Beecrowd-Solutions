/*
beecrowd | 1153 - Fatorial Simples

Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.

Entrada: A entrada contém um valor inteiro N (0 < N < 13).

Saída: A saída contém um valor inteiro, correspondente ao fatorial de N.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int n, total = 1;

        n = int.Parse(Console.ReadLine());

        for (int i = n; i > 0; i--)
        {
            total = total * i;
        }

        Console.WriteLine("{0}", total);
    }
}
