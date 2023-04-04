/*
beecrowd | 1134 - Tipo de Combustível

Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4.

Entrada: A entrada contém apenas valores inteiros e positivos.

Saída: Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int codigo, alcool = 0, gasolina = 0, diesel = 0;

        do
        {
            do
            {
                codigo = int.Parse(Console.ReadLine());

            } while (codigo < 1 || codigo > 4);  
            
            switch (codigo)
            {
                case 1:
                    alcool++;
                    break;
                case 2:
                    gasolina++;
                    break;

                case 3:
                    diesel++;
                    break;
                case 4:
                    break;
                default:
                    break;
            }
            
        } while (codigo != 4);

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: {0}", alcool);
        Console.WriteLine("Gasolina: {0}", gasolina);
        Console.WriteLine("Diesel: {0}", diesel);
    }
}
