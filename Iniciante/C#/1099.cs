/*
beecrowd | 1099 - Soma de Ímpares Consecutivos II

Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. 
Cada caso de teste consiste de dois inteiros X e Y. Você deve apresentar a soma de todos os ímpares existentes entre X e Y.

Entrada: A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir. 
Cada caso de teste consiste em uma linha contendo dois inteiros X e Y.

Saída: Imprima a soma de todos valores ímpares entre X e Y.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int numeroCasos, valor1, valor2, impares = 0;

        numeroCasos = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < numeroCasos; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            valor1 = int.Parse(valores[0]);
            valor2 = int.Parse(valores[1]);


            if (valor1 == valor2)
            {
                Console.WriteLine("0");
            }
            
            else if (valor1 > valor2)
            {
                for (int j = valor2 + 1; j < valor1; j++)
                {
                    if (j % 2 != 0)
                    {
                        impares = impares + j;
                    }
                }
                Console.WriteLine("{0}", impares);
                impares = 0;
            }
            
            else if(valor2 > valor1)
            {
                for (int j = valor1 + 1; j < valor2; j++)
                {
                    if (j % 2 != 0)
                    {
                        impares = impares + j;
                    }
                }
                Console.WriteLine("{0}", impares);
                impares = 0;
            } 
        }
    }
}
