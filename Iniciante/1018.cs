/*
beecrowd | 1018 - Cédulas

Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. 
As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

Entrada: O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

Saída: Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido.

Exemplo: 	
  576
  5 nota(s) de R$ 100,00
  1 nota(s) de R$ 50,00
  1 nota(s) de R$ 20,00
  0 nota(s) de R$ 10,00
  1 nota(s) de R$ 5,00
  0 nota(s) de R$ 2,00
  1 nota(s) de R$ 1,00
*/

using System; 

class URI 
{

    static void Main(string[] args) 
    { 
        int notas, valor;
        
        valor = int.Parse(Console.ReadLine()); // 576
        
        Console.WriteLine("{0}", valor);

        //Notas de 100
        notas = valor / 100; // 5
        valor = valor % 100; // 76
        Console.WriteLine("{0} nota(s) de R$ 100,00", notas);

        //Notas de 50
        notas = valor / 50; // 1
        valor = valor % 50; // 26  
        Console.WriteLine("{0} nota(s) de R$ 50,00", notas);

        //Notas de 20
        notas = valor / 20; // 1
        valor = valor % 20; // 6       
        Console.WriteLine("{0} nota(s) de R$ 20,00", notas);
        
        //Notas de 10
        notas = valor / 10; // 0
        valor = valor % 10; // 6       
        Console.WriteLine("{0} nota(s) de R$ 10,00", notas);

        //Notas de 5
        notas = valor / 5; // 1
        valor = valor % 5; // 1       
        Console.WriteLine("{0} nota(s) de R$ 5,00", notas);

        //Notas de 2
        notas = valor / 2; // 0
        valor = valor % 2; // 1       
        Console.WriteLine("{0} nota(s) de R$ 2,00", notas);

        //Notas de 1
        notas = valor / 1; // 1
        valor = valor % 1; // 0        
        Console.WriteLine("{0} nota(s) de R$ 1,00", notas);
    }

}
