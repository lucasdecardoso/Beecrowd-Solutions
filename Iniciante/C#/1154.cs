/*
beecrowd | 1154 - Idades

Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. 
O último dado, que não entrará nos cálculos, contém o valor de idade negativa. 
Calcular e imprimir a idade média deste grupo de indivíduos.

Entrada: A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.

Saída: A saída contém um valor correspondente à média de idade dos indivíduos. A média deve ser impressa com dois dígitos após o ponto decimal.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double total = 0;
        int idade;
        int count = 0;

        do 
        {
            idade = int.Parse(Console.ReadLine());
            if (idade > 0)
            {
                total = total + idade;
                count++;
            }
        }while (idade > 0);

        Console.WriteLine((total / count).ToString("F2", CultureInfo.InvariantCulture));

    }
}
