/*
beecrowd | 1078 - Tabuada

Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N: 1 x N = N      2 x N = 2N        ...       10 x N = 10N

Entrada: A entrada contém um valor inteiro N (2 < N < 1000).

Saída: Imprima a tabuada de N, conforme o exemplo fornecido.
*/

using System;

class URI
{

    static void Main(string[] args)
    {

        int valor;

        valor = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", i, valor, i * valor);
        }
    }
}
