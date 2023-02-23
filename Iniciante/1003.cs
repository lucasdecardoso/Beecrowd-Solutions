/*
beecrowd | 1003 - Soma Simples

Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA. A seguir escrever o valor desta variável.

Entrada: O arquivo de entrada contém 2 valores inteiros.

Saída: Imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade seguido pelo valor correspondente à soma de A e B. 
*/

using System; 

class URI {

    static void Main(string[] args) 
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        Console.WriteLine("SOMA = {0}", A + B);
    }

}
