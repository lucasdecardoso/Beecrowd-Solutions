/*
beecrowd | 1101 - Sequência de Números e Soma

Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero).
Para cada par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).

Entrada: O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo.

Saída: Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo.

Exemplo: 2 3 4 5 Sum=14
         3 4 5 6 Sum=18
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int numeroCasos, valor1, valor2, soma = 0;


        do
        {
            string[] valores = Console.ReadLine().Split(' ');
            valor1 = int.Parse(valores[0]);
            valor2 = int.Parse(valores[1]);
            soma = 0;

            if (valor1 > 0 && valor2 > 0)
            {

                if (valor1 > valor2)
                {
                    for (int i = valor2; i <= valor1; i++)
                    {
                        Console.Write(i+" ");
                        soma = soma + i;
                    }
                    Console.WriteLine("Sum={0}", soma);
                }
                
                else if (valor2 > valor1)
                {
                    for (int i = valor1; i <= valor2; i++)
                    {
                        Console.Write(i+" ");
                        soma = soma + i;
                    }
                    Console.WriteLine("Sum={0}", soma);
                }
            }
            
        } while(valor1 > 0 && valor2 > 0);
    }
}
