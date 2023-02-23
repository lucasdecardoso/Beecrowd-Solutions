/*
beecrowd | 1015 - Distância Entre Dois Pontos

Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:

Distancia = (Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)); distancia = Math.Sqrt(distancia);

Entrada: O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

Saída: Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.
*/

using System; 
using System.Globalization;

class URI 
{

    static void Main(string[] args) 
    { 
        string[] pontos1 = Console.ReadLine().Split();
        double x1 = double.Parse(pontos1[0], CultureInfo.InvariantCulture);
        double y1 = double.Parse(pontos1[1], CultureInfo.InvariantCulture);

        string[] pontos2 = Console.ReadLine().Split();
        double x2 = double.Parse(pontos2[0], CultureInfo.InvariantCulture);
        double y2 = double.Parse(pontos2[1], CultureInfo.InvariantCulture);
    
        double distancia = (Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
        distancia = Math.Sqrt(distancia);
        

        Console.WriteLine("{0}", distancia.ToString("F4", CultureInfo.GetCultureInfo("en-US")));

    }

}
