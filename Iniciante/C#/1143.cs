/*
beecrowd | 1143 - Quadrado e ao Cubo

Escreva um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada: O arquivo de entrada contém um número inteiro positivo N.

Saída: Imprima a saída conforme o exemplo fornecido.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int n;

        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0} {1} {2}", i, i*i, i*i*i);
        }      
    }
}
