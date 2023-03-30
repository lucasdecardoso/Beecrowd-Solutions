/*
beecrowd | 1065 - Pares entre Cinco Números

Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.

Entrada: O arquivo de entrada contém 5 valores inteiros quaisquer.

Saída: Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de valores pares lidos.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int contador = 0;
        int valor;

        for (int i = 0; i < 5; i++)
        {
            valor = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (valor % 2 == 0)
            {
                contador = contador + 1;
                
            }
            else
            {
                continue;
            }
        }
        
        Console.WriteLine("{0} valores pares", contador);
        
    }
}
