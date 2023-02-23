/*
beecrowd | 1012 - Área

Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.

Entrada: O arquivo de entrada contém três valores com um dígito após o ponto decimal.

Saída: O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.

Exemplo: 	
  TRIANGULO: 7.800
  CIRCULO: 84.949
  TRAPEZIO: 18.200
  QUADRADO: 16.000
  RETANGULO: 12.000
*/


using System; 
using System.Globalization;

class URI 
{

    static void Main(string[] args) 
    { 

        string[] area = Console.ReadLine().Split();

        double A = double.Parse(area[0], CultureInfo.InvariantCulture);
        double B = double.Parse(area[1], CultureInfo.InvariantCulture);
        double C = double.Parse(area[2], CultureInfo.InvariantCulture);

        double areaTriangulo = (A * C) / 2;
        double areaCirculo = 3.14159 * (C * C);
        double areaTrapezio =((A + B) * C) / 2;
        double areaQuadrado = B * B;
        double areaRetangulo = A * B;

        Console.WriteLine("TRIANGULO: {0}", areaTriangulo.ToString("F3", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("CIRCULO: {0}", areaCirculo.ToString("F3", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("TRAPEZIO: {0}", areaTrapezio.ToString("F3", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("QUADRADO: {0}", areaQuadrado.ToString("F3", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("RETANGULO: {0}", areaRetangulo.ToString("F3", CultureInfo.GetCultureInfo("en-US")));
    }

}
