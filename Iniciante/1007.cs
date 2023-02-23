/*
beecrowd | 1007 - Diferença

Leia quatro valores inteiros A, B, C e D. 
A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

Entrada: O arquivo de entrada contém 4 valores inteiros.

Saída: Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.

Exemplo: DIFERENCA = -26
*/


using System;


class URI 
{

    static void Main(string[] args) 
    { 

        double A = int.Parse(Console.ReadLine());
        double B = int.Parse(Console.ReadLine());
        double C = int.Parse(Console.ReadLine());
        double D = int.Parse(Console.ReadLine());

        Console.WriteLine("DIFERENCA = {0}", (A * B) - (C * D));

    }

}
