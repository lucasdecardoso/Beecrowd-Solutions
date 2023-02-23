/*
beecrowd | 1010 - Cálculo Simples

Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. 
Após, calcule e mostre o valor a ser pago.

Entrada: O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída: A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.

Exemplo: VALOR A PAGAR: R$ 15.50
*/


using System; 
using System.Globalization;

class URI 
{

    static void Main(string[] args) 
    { 
        string[] Peca1 = Console.ReadLine().Split();
        int codigoPeca = int.Parse(Peca1[0]);
        int quantidadePeca = int.Parse(Peca1[1]);
        double valorUnitario = double.Parse(Peca1[2], CultureInfo.InvariantCulture);

        string[] Peca2 = Console.ReadLine().Split();
        int codigoPeca2 = int.Parse(Peca2[0]);
        int quantidadePeca2 = int.Parse(Peca2[1]);
        double valorUnitario2 = double.Parse(Peca2[2], CultureInfo.InvariantCulture);

        double valorTotal = (quantidadePeca * valorUnitario) + (quantidadePeca2 * valorUnitario2);
        
        Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.GetCultureInfo("en-US")));
         

    }

}
