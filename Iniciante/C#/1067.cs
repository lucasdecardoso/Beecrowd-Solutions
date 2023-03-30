/*
beecrowd | 1067 - Números Ímpares

Leia um valor inteiro X (1 <= X <= 1000).
Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

Entrada: O arquivo de entrada contém 1 valor inteiro qualquer.

Saída: Imprima todos os valores ímpares de 1 até X, inclusive X, se for o caso.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int valor = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= valor; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine("{0}", i);
            }
            else
            {
                continue;
            }            
        }        
    }
}
