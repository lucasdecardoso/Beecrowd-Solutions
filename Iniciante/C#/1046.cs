/*
beecrowd | 1046 - Tempo de Jogo

Leia a hora inicial e a hora final de um jogo. 
A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

Entrada: A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

Saída: Apresente a duração do jogo conforme exemplo abaixo.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int valorA, valorB, tempo;

        string[] valores = Console.ReadLine().Split(' ');
        valorA = int.Parse(valores[0]);
        valorB = int.Parse(valores[1]);

        if (valorA == valorB)
        {
            Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        }
        else if(valorA > valorB)
        {
            tempo = (24 - valorA) + valorB;
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", tempo);
        }
        else
        {
            tempo = valorB - valorA;
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", tempo);
        }    
    }
}
