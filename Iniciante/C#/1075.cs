/*
beecrowd | 1075 - Resto 2

Leia um valor inteiro N. Apresente todos os números entre 1 e 10000 que divididos por N dão resto igual a 2.

Entrada: A entrada contém um valor inteiro N (N < 10000).

Saída: Imprima todos valores que quando divididos por N dão resto = 2, um por linha.
*/

using System;

class URI
{

    static void Main(string[] args)
    {

        int valor;

        valor = int.Parse(Console.ReadLine());

        for(int i = 1; i < 10000; i++)
        {
            if ( i % valor == 2)
            {
                Console.WriteLine(i);
            }
            else
            {
                continue;
            }
        }
    }
}
