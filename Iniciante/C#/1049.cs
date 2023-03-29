/*
beecrowd | 1049 - Animal

Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  
Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

Entrada: A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

Saída: Imprima o nome do animal correspondente à entrada fornecida.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        string dica1, dica2, dica3;

        dica1 = Console.ReadLine();
        dica2 = Console.ReadLine();
        dica3 = Console.ReadLine();

        if (dica1 == "vertebrado")
        {
            if (dica2 == "ave")
            {
                if (dica3 == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else
                {
                    Console.WriteLine("pomba");
                }

            }
            else if (dica2 == "mamifero")
            {
                if (dica3 == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else
                {
                    Console.WriteLine("vaca");
                }
            }
        }
        else if (dica1 == "invertebrado")
        {
            if (dica2 == "inseto")
            {
                if (dica3 == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else
                {
                    Console.WriteLine("lagarta");
                }

            }
            else if (dica2 == "anelideo")
            {
                if (dica3 == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}
