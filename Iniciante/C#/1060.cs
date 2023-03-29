/*
beecrowd | 1060 - Números Positivos

Faça um programa que leia 6 valores. 
Estes valores serão somente negativos ou positivos (desconsidere os valores nulos). 
A seguir, mostre a quantidade de valores positivos digitados.

Entrada: Seis valores, negativos e/ou positivos.

Saída: Imprima uma mensagem dizendo quantos valores positivos foram lidos.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int contador = 0;

        for (int i = 0; i < 6; i++)
        {
            double valor = double.Parse(Console.ReadLine());
            
            if (valor > 0)
            {
                contador = contador + 1;
            }
            else
            {
                continue;
            }  
        }
        
        Console.WriteLine("{0} valores positivos", contador);
    }
}
