/*
beecrowd | 1117 - Validação de Nota

Faça um programa que leia as notas referentes às duas avaliações de um aluno. 
Calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). 
Cada nota deve ser validada separadamente.

Entrada: A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.

Saída: Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. 
O valor deve ser apresentado com duas casas após o ponto decimal.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int numeroCasos;
        double nota, validas = 0, media = 0;

        while(validas != 2)
        {
            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (nota >= 0.0 && nota <= 10.00)
            {
                media = media + nota;
                validas = validas + 1;
            }
            else
            {
                Console.WriteLine("nota invalida");
            }
        }

        Console.WriteLine("media = {0}", (media / 2).ToString("F2", CultureInfo.InvariantCulture));
    }
}
