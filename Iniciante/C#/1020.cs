/*
beecrowd | 1020 - Idade em Dias

Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias.

Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. 
Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

Entrada: O arquivo de entrada contém um valor inteiro.

Saída: Imprima a saída conforme exemplo fornecido.
*/

using System; 

class URI 
{

    static void Main(string[] args) 
    { 
        int dias, meses, anos;
        
        dias = int.Parse(Console.ReadLine()); // 400

        //Descobrindo o ano
        anos = dias / 365; //1
         
         //Descobrindo os meses         
        dias = dias % 365; // 35
        meses = dias / 30; // 1

         //Descobrindo os dias restantes
        dias = dias % 30; //5

        Console.WriteLine("{0} ano(s)", anos);
        Console.WriteLine("{0} mes(es)", meses);
        Console.WriteLine("{0} dia(s)", dias);
    }

}
