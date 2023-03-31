/*
beecrowd | 1095 - Sequencia IJ 1

Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

Entrada: Não há nenhuma entrada neste problema.

Saída: Imprima a sequencia conforme exemplo abaixo
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int i = 1, j;
        
        for (j = 60; j >= 0 ; )
        {
            Console.WriteLine("I={0} J={1}", i, j);
            i = i + 3;
            j = j - 5;
        }
    }
}
