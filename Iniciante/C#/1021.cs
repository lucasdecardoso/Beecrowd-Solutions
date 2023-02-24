/*
beecrowd | 1021 - Notas e Moedas

Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. 
A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. 
As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. 
A seguir mostre a relação de notas necessárias.

Entrada: O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

Saída: Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

Obs: Utilize ponto (.) para separar a parte decimal.

Exemplo:
  NOTAS:
  5 nota(s) de R$ 100.00
  1 nota(s) de R$ 50.00
  1 nota(s) de R$ 20.00
  0 nota(s) de R$ 10.00
  1 nota(s) de R$ 5.00
  0 nota(s) de R$ 2.00
  MOEDAS:
  1 moeda(s) de R$ 1.00
  1 moeda(s) de R$ 0.50
  0 moeda(s) de R$ 0.25
  2 moeda(s) de R$ 0.10
  0 moeda(s) de R$ 0.05
  3 moeda(s) de R$ 0.01
*/

using System; 

class URI 
{

    static void Main(string[] args) 
    { 
        int notas, valor;
        int moedas, centavos;
        
        string[] valorTotal = Console.ReadLine().Split('.'); //576.73
        valor = int.Parse(valorTotal[0]); // 576
        centavos = int.Parse(valorTotal[1]); // 73
        
        Console.WriteLine("NOTAS:");

        //Notas de 100
        notas = valor / 100; // 5
        valor = valor % 100; // 76
        Console.WriteLine("{0} nota(s) de R$ 100.00", notas);

        //Notas de 50
        notas = valor / 50; // 1
        valor = valor % 50; // 26  
        Console.WriteLine("{0} nota(s) de R$ 50.00", notas);

        //Notas de 20
        notas = valor / 20; // 1
        valor = valor % 20; // 6       
        Console.WriteLine("{0} nota(s) de R$ 20.00", notas);
        
        //Notas de 10
        notas = valor / 10; // 0
        valor = valor % 10; // 6       
        Console.WriteLine("{0} nota(s) de R$ 10.00", notas);

        //Notas de 5
        notas = valor / 5; // 1
        valor = valor % 5; // 1       
        Console.WriteLine("{0} nota(s) de R$ 5.00", notas);

        //Notas de 2
        notas = valor / 2; // 0
        valor = valor % 2; // 1       
        Console.WriteLine("{0} nota(s) de R$ 2.00", notas);
        
        
        Console.WriteLine("MOEDAS:");

        //Moedas de 1
        notas = valor / 1; // 1
        valor = valor % 1; // 0        
        Console.WriteLine("{0} moeda(s) de R$ 1.00", notas);

        //Moedas de 0.50
        moedas = centavos / 50;
        centavos = centavos % 50;
        Console.WriteLine("{0} moeda(s) de R$ 0.50", moedas);           
   
        //Moedas de 0.25
        moedas = centavos / 25;
        centavos = centavos % 25;
        Console.WriteLine("{0} moeda(s) de R$ 0.25", moedas);    
 
        //Moedas de 0.10
        moedas = centavos / 10;
        centavos = centavos % 10;
        Console.WriteLine("{0} moeda(s) de R$ 0.10", moedas); 
       
       //Moedas de 0.05
        moedas = centavos / 5;
        centavos = centavos % 5;
        Console.WriteLine("{0} moeda(s) de R$ 0.05", moedas); 
      
        //Moedas de 0.01
        moedas = centavos / 1;
        centavos = centavos % 1;
        Console.WriteLine("{0} moeda(s) de R$ 0.01", moedas);  

  }

}
