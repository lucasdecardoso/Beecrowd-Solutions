/*
beecrowd | 1042 - Sort Simples

Leia 3 valores inteiros e ordene-os em ordem crescente. 
No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.

Entrada: A entrada contem três números inteiros.

Saída: Imprima a saída conforme foi especificado.
*/

using System; 

class URI 
{

    static void Main(string[] args) 
    {        
        int valor1, valor2, valor3;

        string[] valores = Console.ReadLine().Split(' ');
        valor1 = int.Parse(valores[0]);
        valor2 = int.Parse(valores[1]);
        valor3 = int.Parse(valores[2]);

        if (valor1 < valor2 && valor1 < valor3) //caso valor1 seja o menor
        {
            Console.WriteLine("{0}", valor1);

            if (valor2 < valor3)
            {
                Console.WriteLine("{0}", valor2);
                Console.WriteLine("{0}", valor3);
            }
            else
            {
                Console.WriteLine("{0}", valor3);
                Console.WriteLine("{0}", valor2);
            }
        }
        else if (valor2 < valor1 && valor2 < valor3) //caso valor2 seja o menor
        {
            Console.WriteLine("{0}", valor2);
            
            if (valor1 < valor3)
            {
                Console.WriteLine("{0}", valor1);
                Console.WriteLine("{0}", valor3);
            }
            else
            {
                Console.WriteLine("{0}", valor3);
                Console.WriteLine("{0}", valor1);
            }
        }
        else if(valor3 < valor1 && valor3 < valor2) //caso valor3 seja o menor
        {
            Console.WriteLine("{0}", valor3);
            
            if (valor1 < valor2)
            {
                Console.WriteLine("{0}", valor1);
                Console.WriteLine("{0}", valor2);
            }
            else
            {
                Console.WriteLine("{0}", valor2);
                Console.WriteLine("{0}", valor1);
            }
        }

        Console.WriteLine("\n{0}\n{1}\n{2}", valor1, valor2, valor3);
    }
}
