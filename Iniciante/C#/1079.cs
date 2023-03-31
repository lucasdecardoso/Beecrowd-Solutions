/*
beecrowd | 1079 - Médias Ponderadas

Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

Entrada: O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir contém um caso de teste com três valores com uma casa decimal cada valor.

Saída: Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int numeroCasos;
        double media;
        

        numeroCasos = int.Parse(Console.ReadLine());

        for(int i = 0; i < numeroCasos; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            media = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / 10;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
