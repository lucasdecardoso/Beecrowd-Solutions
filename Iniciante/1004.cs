/*
beecrowd | 1004 - Produto Simples

Leia dois valores inteiros. 
A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. 
A seguir mostre a variável PROD com mensagem correspondente.   

Entrada: O arquivo de entrada contém 2 valores inteiros.

Saída: Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.

Exemplo: PROD = 27
*/

using System; 

class URI {

    static void Main(string[] args)     
    { 
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        Console.WriteLine("PROD = {0}", A * B);
    }

}
