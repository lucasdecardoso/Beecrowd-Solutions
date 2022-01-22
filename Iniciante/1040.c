#include <stdio.h>

int main()
{
    float N1, N2, N3, N4, media, exame,mediaexame;

    scanf("%f %f %f %f", &N1, &N2, &N3, &N4);

    media = ( (N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1) ) / 10;

    printf("Media: %0.1f\n", media);


    if (media >= 7.0)
    {
        printf("Aluno aprovado.\n");
    }

    else if (media < 5.0)
    {
        printf("Aluno reprovado.\n");
    }
    else
    {
        printf("Aluno em exame.\n");

        scanf("%f", &exame);

        printf("Nota do exame: %0.1f\n", exame);

        mediaexame = (media + exame) / 2;

        if (mediaexame > 5.0)
        {
            printf("Aluno aprovado.\n");
            printf("Media final: %0.1f\n", mediaexame);
        }
        else {printf("Aluno reprovado.\n");
             printf("Media final: %0.1f\n", mediaexame);

            }




    }


    return 0;
}
