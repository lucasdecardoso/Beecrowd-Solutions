/*
beecrowd | 1176 - Fibonacci em Vetor

Faça um programa que leia um valor e apresente o número de Fibonacci correspondente a este valor lido. 
Lembre que os 2 primeiros elementos da série de Fibonacci são 0 e 1 e cada próximo termo é a soma dos 2 anteriores a ele. 
Todos os valores de Fibonacci calculados neste problema devem caber em um inteiro de 64 bits sem sinal.

Entrada: A primeira linha da entrada contém um inteiro T, indicando o número de casos de teste. 
Cada caso de teste contém um único inteiro N (0 ≤ N ≤ 60), correspondente ao N-esimo termo da série de Fibonacci.

Saída: Para cada caso de teste da entrada, imprima a mensagem "Fib(N) = X", onde X é o N-ésimo termo da série de Fibonacci.
*/

using System;
using System.Collections.Generic;

class URI
{
    static List<long> CalcularFibonacci(int n) //Calcular fibo e adicionar em uma lista de tamanho determinado pelo usuario
    {
        List<long> listaFibo = new List<long> { 0, 1 };

        for (int i = 2; i < n + 1; i++)
        {
            listaFibo.Add(listaFibo[i - 1] + listaFibo[i - 2]);
        }

        return listaFibo;
    }

    static void Main(string[] args) //Programa principal
    {
        var count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            var n = int.Parse(Console.ReadLine());
            List<long> resultado = CalcularFibonacci(n);
            Console.Write("Fib({0}) = {1}\n", n, resultado[n]);
        }
    }
}
