/*
beecrowd | 1113 - Crescente e Decrescente

Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. 
Escreva para cada X e Y uma mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente.

Entrada: A entrada contém vários casos de teste. Cada caso contém dois valores inteiros X e Y. 
A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y.

Saída: Para cada caso de teste imprima “Crescente”, caso os valores tenham sido digitados na ordem crescente, caso contrário imprima a mensagem “Decrescente”.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int valor1, valor2;

        do
        {
            string[] valores = Console.ReadLine().Split(' ');
            valor1 = int.Parse(valores[0]);
            valor2 = int.Parse(valores[1]);
            

            if (valor1 != valor2)
            {

                if (valor1 > valor2)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
            }
        } while(valor1 != valor2);
    }
}
