/*
beecrowd | 1036 - Fórmula de Bhaskara

Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. 
Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada: Leia três valores de ponto flutuante (double) A, B e C.

Saída: Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular".
Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. 

Exemplo: R1 = -0.29788
         R2 = -1.71212
*/

using System; 
using System.Globalization;
class URI 
{

    static void Main(string[] args) 
    { 
        double A, B, C, raiz1, raiz2, delta;
        
        string[] valores = Console.ReadLine().Split(' ');
        A = double.Parse(valores[0]); 
        B = double.Parse(valores[1]); 
        C = double.Parse(valores[2]);     

        delta = (B*B) - (4 * A * C);

        if (A == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            raiz1 = (-B + Math.Sqrt(delta)) / (2 * A);
            raiz2 = (-B - Math.Sqrt(delta)) / (2 * A);
            Console.WriteLine("R1 = {0}", raiz1.ToString("F5", CultureInfo.GetCultureInfo("en-US")));
            Console.WriteLine("R2 = {0}", raiz2.ToString("F5", CultureInfo.GetCultureInfo("en-US")));
        }
    }
}
