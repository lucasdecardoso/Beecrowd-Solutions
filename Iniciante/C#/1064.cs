/*
beecrowd | 1064 - Positivos e Média

Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. 
Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.

Entrada: A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.

Saída: O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores positivos digitados.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int contador = 0;
        double media = 0, valor;

        for (int i = 0; i < 6; i++)
        {
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (valor > 0)
            {
                contador = contador + 1;
                media = media + valor;
            }
            else
            {
                continue;
            }               
        }
        
        Console.WriteLine("{0} valores positivos", contador);
        Console.WriteLine("{0}", (media / (double)contador).ToString("F1", CultureInfo.InvariantCulture));
        
    }
}
