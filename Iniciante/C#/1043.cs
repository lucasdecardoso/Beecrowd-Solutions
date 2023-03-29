/*
beecrowd | 1043 - Triângulo

Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. 
Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem: Perimetro = XX.X
Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem: Area = XX.X

Entrada: A entrada contém três valores reais.

Saída: O resultado deve ser apresentado com uma casa decimal.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double valorA, valorB, valorC, perimetro, area;

        string[] valores = Console.ReadLine().Split(' ');
        valorA = double.Parse(valores[0], CultureInfo.InvariantCulture);
        valorB = double.Parse(valores[1], CultureInfo.InvariantCulture);
        valorC = double.Parse(valores[2], CultureInfo.InvariantCulture);

        if (valorA > (valorB - valorC) && valorA < (valorB + valorC))
        {
            if (valorB > (valorA - valorC) && valorB < (valorA + valorC))
            {
                if (valorC > (valorA - valorB) && valorC < (valorA + valorB))
                {
                    perimetro = valorA + valorB + valorC;
                    Console.WriteLine("Perimetro = {0}", perimetro.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
        else
        {
            area = ((valorA + valorB) * valorC) / 2;            
            Console.WriteLine("Area = {0}", area.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
