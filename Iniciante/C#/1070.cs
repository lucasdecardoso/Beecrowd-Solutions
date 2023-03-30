/*
beecrowd | 1070 - Seis Números Ímpares

Leia um valor inteiro X. 
Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.

Entrada: A entrada será um valor inteiro positivo.

Saída: A saída será uma sequência de seis números ímpares.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int contador = 0;
        int valor = int.Parse(Console.ReadLine());
        
        while (contador != 6)
        {
            
                if (valor % 2 != 0)
                {
                    Console.WriteLine("{0}", valor);
                    contador++;
                    valor = valor + 1;
                }
                else
                {
                    valor = valor + 1;
                    continue;
                }
        }
    }
}
