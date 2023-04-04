/*
beecrowd | 1142 - PUM

Escreva um programa que leia um valor inteiro N. Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada: O arquivo de entrada contém um número inteiro positivo N.

Saída: Imprima a saída conforme o exemplo fornecido.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int n, valor = 1;

        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0} {1} {2} PUM", valor, valor + 1, valor + 2);
            valor += 4;
        }      
    }
}
