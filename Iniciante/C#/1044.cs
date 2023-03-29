/*
beecrowd | 1044 - Múltiplos

Leia 2 valores inteiros (A e B). 
Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

Entrada: A entrada contém valores inteiros.

Saída: A saída deve conter uma das mensagens conforme descrito acima.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int valorA, valorB;
        decimal multiplo;

        string[] valores = Console.ReadLine().Split(' ');
        valorA = int.Parse(valores[0]);
        valorB = int.Parse(valores[1]);

        if (valorA > valorB)
        {
            multiplo = (decimal)valorA % valorB;

            if (multiplo == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
        else
        {
            multiplo = (decimal)valorB % valorA;

            if (multiplo == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
