#include <stdio.h>

int main()
{
    float N,i,j,total = 0, media = 0,valor;

    scanf("%f", &N);

    for (j = 0; j < N;j++)
    {




    for ( i = 0; i < 3; i++)
    {


        scanf("%f", &valor);

        if( i == 0){ valor = valor *2; }
        if( i == 1){ valor = valor *3;}
        if( i == 2){ valor = valor *5;}


        total = total + valor;



    }


    media = total / 10;

    printf("%0.1f\n", media);

    i = 0;
    media = 0;
    total = 0;

    }


    return 0;

}
