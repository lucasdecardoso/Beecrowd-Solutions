/*
beecrowd | 1072 - Intervalo 2

Leia um valor inteiro N. 
Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.

Entrada: A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
 

Saída: Para cada caso, imprima quantos números estão dentro (in) e quantos valores estão fora (out) do intervalo.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int valor = 0, dentro = 0, fora = 0;
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            valor = int.Parse(Console.ReadLine());

            if ( valor >= 10 && valor <= 20)
            {
                dentro = dentro + 1;
            }
            else
            {
                fora = fora + 1;
            }
        }        
        Console.WriteLine("{0} in", dentro);
        Console.WriteLine("{0} out", fora);
    }
}
