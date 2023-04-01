/*
beecrowd | 1116 - Dividindo X por Y

Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. 
Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.

Entrada: A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

Saída: Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.

Obs.: Cuide que a divisão entre dois inteiros em algumas linguagens como o C e C++ gera outro inteiro. Utilize cast :)
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int numeroCasos;
        double X, Y;

        numeroCasos = int.Parse(Console.ReadLine());

        for (int i = 0; i < numeroCasos; i++)
        {
            string[] coordenadas = Console.ReadLine().Split(' ');
            X = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            Y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            if (Y != 0)
            {
                Console.WriteLine("{0}", (X / Y).ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("divisao impossivel");
            }
        }
    }
}
