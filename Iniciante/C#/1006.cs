/*
beecrowd | 1006 - Média 2

Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. 
Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

Entrada: O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

Saída: Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. 

Exemplo: MEDIA = 6.3
*/

using System;
using System.Globalization;


class URI 
{

    static void Main(string[] args) 
    { 

        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 2;
        double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 3;
        double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 5;
        Console.WriteLine("MEDIA = {0:F1}", (A + B + C) / 10);

    }

}
