#include <stdio.h>

int main()
{
    int N, i, valor;

    scanf("%d", &N);

    for( i = 1 ; i <= N; i++)
    {

        if( i % 2 == 0)
        {
            valor = i * i;

            printf("%d^2 = %d\n", i, valor);
        }

    }



        return 0;

}
