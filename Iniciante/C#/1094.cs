/*
beecrowd | 1094 - Experiências

Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar os experimentos de um laboratório o qual ela é responsável. 
Ela quer saber no final do ano, quantas cobaias foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada.

Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos.
Para obter estas informações, ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia utilizada e a quantidade de cobaias utilizadas em cada experimento.

Entrada: A primeira linha de entrada contém um valor inteiro N que indica os vários casos de teste que vem a seguir. Cada caso de teste contém um inteiro Quantia (1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas e um caractere Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho).

Saída: Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia utilizada e o percentual de cada uma em relação ao total de cobaias utilizadas, sendo que o percentual deve ser apresentado com dois dígitos após o ponto.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int numeroCasos, quantidade = 0, totalCoelhos = 0, totalRatos = 0, totalSapos = 0, totalCobaias = 0;
        char cobaia;

        numeroCasos = int.Parse(Console.ReadLine());

        for (int i = 0; i < numeroCasos; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            quantidade = int.Parse(valores[0]);
            cobaia = char.Parse(valores[1]);

            if (cobaia == 'C')
            {
                totalCoelhos = totalCoelhos + quantidade;
            }
            else if (cobaia == 'R')
            {
                totalRatos = totalRatos + quantidade;
            }
            else if (cobaia == 'S')
            {
                totalSapos = totalSapos + quantidade;
            }
        }

        totalCobaias = totalCoelhos + totalRatos + totalSapos;

        Console.WriteLine("Total: {0} cobaias", totalCobaias );
        Console.WriteLine("Total de coelhos: {0}", totalCoelhos);
        Console.WriteLine("Total de ratos: {0}", totalRatos);
        Console.WriteLine("Total de sapos: {0}", totalSapos);
        Console.WriteLine("Percentual de coelhos: {0} %", (totalCoelhos / (totalCobaias / 100.00)).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Percentual de ratos: {0} %", (totalRatos / (totalCobaias / 100.00)).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Percentual de sapos: {0} %", (totalSapos / (totalCobaias / 100.00)).ToString("F2", CultureInfo.InvariantCulture));
    }
}
