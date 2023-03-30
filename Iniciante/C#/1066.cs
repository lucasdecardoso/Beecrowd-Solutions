/*
beecrowd | 1066 - Pares, Ímpares, Positivos e Negativos

Leia 5 valores Inteiros. 
A seguir mostre quantos valores digitados foram pares, quantos valores digitados foram ímpares, quantos valores digitados foram positivos e quantos valores digitados foram negativos.

Entrada: O arquivo de entrada contém 5 valores inteiros quaisquer.

Saída: Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não esquecendo o final de linha após cada uma.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        
        int valor, pares = 0, impares = 0, positivos = 0, negativos = 0;

        for (int i = 0; i < 5; i++)
        {
            valor = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (valor % 2 == 0)
            {
                pares = pares + 1;                
            }
            if(valor % 2 != 0)
            {
                impares = impares + 1;
            }
            if(valor > 0)
            {
                positivos = positivos + 1;
            }
            if(valor < 0)
            {
                negativos = negativos + 1;
            }
            else
            {
                continue;
            }            
        }

        Console.WriteLine("{0} valor(es) par(es)", pares);
        Console.WriteLine("{0} valor(es) impar(es)", impares);
        Console.WriteLine("{0} valor(es) positivo(s)", positivos);
        Console.WriteLine("{0} valor(es) negativo(s)", negativos);
        
    }
}
