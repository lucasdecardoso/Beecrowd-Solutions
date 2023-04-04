/*
beecrowd | 1131 - Grenais

A Federação Gaúcha de Futebol contratou você para escrever um programa para fazer uma estatística do resultado de vários GRENAIS. 
Escreva um programa para ler o número de gols marcados pelo Inter e pelo Grêmio em um GRENAL. 
Logo após escrever a mensagem "Novo grenal (1-sim 2-nao)" e solicitar uma resposta. Se a resposta for 1, o algoritmo deve ser executado novamente solicitando o número de gols marcados pelos times em uma nova partida, caso contrário deve ser encerrado imprimindo:

- Quantos GRENAIS fizeram parte da estatística.
- O número de vitórias do Inter.
- O número de vitórias do Grêmio.
- O número de Empates.
- Uma mensagem indicando qual o time que venceu o maior número de GRENAIS (ou "Nao houve vencedor", caso termine empatado).

Entrada: O arquivo de entrada contém 2 valores inteiros, correspondentes aos gols marcados pelo Inter e pelo Grêmio respectivamente. 
Em seguida háverá um inteiro (1 ou 2), correspondente à repetição do programa.

Saída: Após cada leitura dos gols, deve ser impressa a mensagem "Novo grenal (1-sim 2-nao)". 
Quando o algoritmo for encerrado devem ser mostradas as estatísticas conforme a descrição apresentada acima. 
Obs: a palavra "Gremio" deve ser impressa sem acento.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int inter = 0, gremio = 0, empates = 0, grenais = 0;
        string novoCalculo;

        do
        {
            grenais++;
            string[] placar = Console.ReadLine().Split(' ');
         
            if (placar[0] == placar[1])
            {
                empates = empates + 1;
            }
            else if (int.Parse(placar[0]) > int.Parse(placar[1]))
            {
                inter = inter + 1;
            }
            else if(int.Parse(placar[0]) < int.Parse(placar[1]))
            {
                gremio = gremio + 1;
            }
            
            do
            {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoCalculo = Console.ReadLine();
            } while (novoCalculo != "1" && novoCalculo != "2");               
        
        } while (novoCalculo == "1");

        Console.WriteLine("{0} grenais", grenais);
        Console.WriteLine("Inter:{0}", inter);
        Console.WriteLine("Gremio:{0}", gremio);
        Console.WriteLine("Empates:{0}", empates);

        if (inter > gremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else if (gremio > inter)
        {
            Console.WriteLine("Gremio venceu mais");
        }
    }
}
