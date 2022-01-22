#include <stdio.h>

int main()
{
    int aux, A,B;

    scanf("%d %d", &A, &B);

    if (A > B)
    {
        aux = (24 - A) + B;

        printf("O JOGO DUROU %d HORA(S)\n",aux);
    }

    if ( A == B)
    {
            printf("O JOGO DUROU 24 HORA(S)\n");

    }

    if (A < B)
    {

            aux = B - A;

            printf("O JOGO DUROU %d HORA(S)\n",aux);

    }



    return 0;
}
