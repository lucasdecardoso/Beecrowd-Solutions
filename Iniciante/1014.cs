/*
beecrowd | 1014 - Consumo

Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).

Entrada: O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

Saída: Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".

Exemplo: 14.286 km/l
*/

using System; 
using System.Globalization;

class URI 
{

    static void Main(string[] args) 
    { 
        int distanciaPercorrida = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double consumo = distanciaPercorrida / combustivel;

        Console.WriteLine("{0} km/l", consumo.ToString("F3", CultureInfo.GetCultureInfo("en-US")));

    }

}
