#include <stdio.h>

int main()
{
    int N,i, par = 0, impar = 0,  negativo = 0, positivo = 0;


    for(i = 0; i < 5; i++)
    {

        scanf("%d", &N);

    {
        if (N  % 2 == 0 )
        {
            par = par + 1;
        }
        if( N % 2 != 0)
        {
            impar = impar + 1;
        }
        if( N > 0)
        {
            positivo = positivo + 1;
        }
        if ( N < 0)
        {
            negativo = negativo + 1;
        }
    }



    }

    printf("%d valor(es) par(es)\n",par);
    printf("%d valor(es) impar(es)\n",impar);
    printf("%d valor(es) positivo(s)\n",positivo);
    printf("%d valor(es) negativo(s)\n",negativo);




    return 0;

}
