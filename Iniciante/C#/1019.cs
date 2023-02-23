/*
beecrowd | 1019 - Conversão de Tempo

Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

Entrada: O arquivo de entrada contém um valor inteiro N.

Saída: Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

Exemplo: 0:9:16
*/

using System; 

class URI 
{

    static void Main(string[] args) 
    { 
        int horas, minutos, segundos;
        
        segundos = int.Parse(Console.ReadLine()); // 556

        //Descobrindo as horas
        horas = (segundos / 60) / 60;

        //Descobrindo os minutos         
        minutos = segundos - ((horas * 60) * 60);
        minutos = minutos / 60;

        //Descobrindo os segundos
        segundos = segundos % 60;

        System.Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
    }

}
