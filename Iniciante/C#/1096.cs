/*
beecrowd | 1096 - Sequencia IJ 2

Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

Entrada: Não há nenhuma entrada neste problema.

Saída: Imprima a sequencia conforme exemplo abaixo

Exemplo:
  I=1 J=7
  I=1 J=6
  I=1 J=5
  I=3 J=7
  I=3 J=6
  I=3 J=5
  ...
  I=9 J=7
  I=9 J=6
  I=9 J=5
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int i = 1, j;
        
        for (i = 1; i <= 9; i = i + 2 )
        {
            for (j = 7; j > 4 ; j--)
            {
                Console.WriteLine("I={0} J={1}", i, j);
            }
        }
    }
}
