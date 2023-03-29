/*
beecrowd | 1045 - Tipos de Triângulos

Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. 
A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

• se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
• se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
• se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
• se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
• se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
• se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

Entrada: A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

Saída: Imprima todas as classificações do triângulo especificado na entrada.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        decimal valorA, valorB, valorC, temp;

        string[] valores = Console.ReadLine().Split(' ');
        valorA = decimal.Parse(valores[0], CultureInfo.InvariantCulture);
        valorB = decimal.Parse(valores[1], CultureInfo.InvariantCulture);
        valorC = decimal.Parse(valores[2], CultureInfo.InvariantCulture);

        if (valorA < valorB)
        {
            temp = valorA;
            valorA = valorB;
            valorB = temp;
        }
        if (valorB < valorC)
        {
            temp = valorB;
            valorB = valorC;
            valorC = temp;
        }
        if (valorA < valorB)
        {
            temp = valorA;
            valorA = valorB;
            valorB = temp;
        }

        if (valorA >= valorB + valorC)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else if (valorA*valorA == (valorB*valorB) + (valorC*valorC))
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if (valorA*valorA > (valorB*valorB) + (valorC*valorC))
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else if (valorA*valorA < (valorB*valorB) + (valorC*valorC))
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }
        if (valorA == valorB && valorA == valorC)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");

        }
        else if(valorA == valorB || valorB == valorC || valorA == valorC)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}
