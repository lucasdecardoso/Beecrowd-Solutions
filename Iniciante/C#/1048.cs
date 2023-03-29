/*
URI Online Judge | 1048 - Aumento de Salário

A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.

Entrada: A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

Saída: Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste (ambos devem ser apresentados com 2 casas decimais) e o percentual de reajuste ganho.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double salario, reajuste;

        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (salario > 0 && salario <= 400)
        {
            reajuste = salario * 0.15;
            salario = salario + reajuste;
            Console.WriteLine("Novo salario: {0}", salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: 15 %");
        }
        else if (salario > 400 && salario <= 800)
        {
            reajuste = salario * 0.12;
            salario = salario + reajuste;
            Console.WriteLine("Novo salario: {0}", salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: 12 %");
        }
        else if (salario > 800 && salario <= 1200)
        {
            reajuste = salario * 0.10;
            salario = salario + reajuste;
            Console.WriteLine("Novo salario: {0}", salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: 10 %");
        }
        else if (salario > 1200 && salario <= 2000)
        {
            reajuste = salario * 0.07;
            salario = salario + reajuste;
            Console.WriteLine("Novo salario: {0}", salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: 7 %");
        }
        else if (salario > 2000)
        {
            reajuste = salario * 0.04;
            salario = salario + reajuste;
            Console.WriteLine("Novo salario: {0}", salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: 4 %");
        }    
    }

}
