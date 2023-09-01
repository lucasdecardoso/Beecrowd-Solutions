/*
beecrowd | 1151 - Fibonacci Fácil

A seguinte sequência de números 0 1 1 2 3 5 8 13 21... é conhecida como série de Fibonacci.
Nessa sequência, cada número, depois dos 2 primeiros, é igual à soma dos 2 anteriores. 
Escreva um algoritmo que leia um inteiro N (N < 46) e mostre os N primeiros números dessa série.

Entrada: O arquivo de entrada contém um valor inteiro N (0 < N < 46).

Saída: Os valores devem ser mostrados na mesma linha, separados por um espaço em branco. Não deve haver espaço após o último valor.
*/

using System;
using System.Collections.Generic;

class URI
{
    static List<int> CalcularFibonacci(int n) //Calcular fibo e adicionar em uma lista de tamanho determinado pelo usuario
    {
        List<int> listaFibo = new List<int> { 0, 1 };

        for (int i = 2; i < n; i++)
        {
            listaFibo.Add(listaFibo[i - 1] + listaFibo[i - 2]);
        }

        return listaFibo;
    }

  
    static void Main(string[] args) //Programa principal
    {

        var n = int.Parse(Console.ReadLine());

        List<int> resultado = CalcularFibonacci(n);

        for (int i = 0; i < n; i++)
        {
            Console.Write(resultado[i]);
            if (i < n - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
