/*
beecrowd | 1040 - Média 3

Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. 
Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". 
Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". 
Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". 
Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. 
Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. 
Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). 
Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.

Entrada: A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos.

Saída: Todas as respostas devem ser apresentadas com uma casa decimal. As mensagens devem ser impressas conforme a descrição do problema. 
Não esqueça de imprimir o enter após o final de cada linha, caso contrário obterá "Presentation Error".
*/

using System; 
using System.Globalization;

class URI 
{

    static void Main(string[] args) 
    {        
        double mediaTotal, nota1, nota2, nota3, nota4;

        string[] notas = Console.ReadLine().Split(' ');
        nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
        nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
        nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
        nota4 = double.Parse(notas[3], CultureInfo.InvariantCulture);

        mediaTotal = ((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + (nota4 * 1)) / 10;
        Console.WriteLine("Media: {0}", (mediaTotal - 0.01).ToString("F1", CultureInfo.InvariantCulture));

        if (mediaTotal >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if(mediaTotal < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");         

            double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota do exame: {0}", notaExame.ToString("F1", CultureInfo.InvariantCulture));
            double MediaFinal = (notaExame + mediaTotal) / 2;      

            if (MediaFinal > 5.0)
            {
                Console.WriteLine("Aluno aprovado.");                
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine("Media final: {0}", MediaFinal.ToString("F1", CultureInfo.InvariantCulture));
        }    
    }
}
