/*
beecrowd | 1071 - Soma de Impares Consecutivos I

Leia 2 valores inteiros X e Y. 
A seguir, calcule e mostre a soma dos números impares entre eles.

Entrada: O arquivo de entrada contém dois valores inteiros.

Saída: O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares que estão entre os valores fornecidos na entrada que deverá caber em um inteiro.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int contador = 0, soma = 0;
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());

        if (X > Y)
        {
            for (int i = Y + 1; i < X; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
                else
                {
                    continue;
                }
            }
        }
        else
        {
            for (int i = X + 1; i < Y; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
                else
                {
                    continue;
                }
            }
        }
        Console.WriteLine("{0}", soma);
    }
}
