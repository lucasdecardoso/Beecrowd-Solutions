/*
A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:

- Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

Entrada: A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.

Saída: Apresentar a mensagem "A=" seguido pelo valor da variável area, com 4 casas após o ponto decimal. Utilize variáveis de dupla precisão (double). 
*/

using System;

namespace URITests
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine());

            double area = n * (raio * raio);

            Console.WriteLine("A={0:F4}", area);
        }
    }
}
