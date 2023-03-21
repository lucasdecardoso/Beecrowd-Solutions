/*
beecrowd | 1038 - Lanche

Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. 
A seguir, calcule e mostre o valor da conta a pagar.

Entrada: O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.

Saída: O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.
*/

using System; 
using System.Globalization;

class URI 
{

    static void Main(string[] args) 
    {        
        string[] valores = Console.ReadLine().Split(' ');
        int codigo = int.Parse(valores[0]);
        double quantidade = double.Parse(valores[1]);

        switch (codigo)
        {
            case 1:            
                Console.WriteLine("Total: R$ {0}", (quantidade * 4.00).ToString("F2", CultureInfo.InvariantCulture));
                break;

            case 2:
                Console.WriteLine("Total: R$ {0}", (quantidade * 4.50).ToString("F2", CultureInfo.InvariantCulture));
                break;

            case 3:
                Console.WriteLine("Total: R$ {0}", (quantidade * 5.00).ToString("F2", CultureInfo.InvariantCulture));
                break;

            case 4:
                Console.WriteLine("Total: R$ {0}", (quantidade * 2.00).ToString("F2", CultureInfo.InvariantCulture));
                break;

            case 5:
                Console.WriteLine("Total: R$ {0}", (quantidade * 1.50).ToString("F2", CultureInfo.InvariantCulture));
                break;

            default:
                Console.WriteLine("Codigo incorreto");
                break;
        } 
    }
}
