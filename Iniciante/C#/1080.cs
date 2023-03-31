/*
beecrowd | 1080 - Maior e Posição

Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

Entrada: O arquivo de entrada contém 100 números inteiros, positivos e distintos.

Saída: Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int maiorValor = 0, valor, posicao = 0;

        for (int i = 1; i <= 100; i++)
        {
            valor = int.Parse(Console.ReadLine());

            if (valor > maiorValor)
            {
                maiorValor = valor;
                posicao = i;
            }

        }
            Console.WriteLine(maiorValor);
            Console.WriteLine(posicao);
    }
}
