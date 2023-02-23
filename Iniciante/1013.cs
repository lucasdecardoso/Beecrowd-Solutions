/*
URI Online Judge | 1013 - O Maior

Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula: maiorAB = (A + B + Abs(A - B)) / 2.

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada: O arquivo de entrada contém três valores inteiros.

Saída: Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
*/

using System; 
using System.Globalization;

class URI 
{

    static void Main(string[] args) 
    { 
        string[] valores = Console.ReadLine().Split(' ');
        int A = int.Parse(valores[0], CultureInfo.InvariantCulture);
        int B = int.Parse(valores[1], CultureInfo.InvariantCulture);
        int C = int.Parse(valores[2], CultureInfo.InvariantCulture);

        int maiorAB = (A + B + Math.Abs(A - B)) / 2;
        int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

        Console.WriteLine("{0} eh o maior", maiorABC);

    }

}
