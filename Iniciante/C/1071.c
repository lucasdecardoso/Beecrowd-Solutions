#include <stdio.h>

int main()
{
    int X,Y, i, soma = 0;

    scanf("%d", &X);
    scanf("%d", &Y);

    if( X == Y)
    {
        printf("0\n");

    }
    else if( X > Y)
    {
        for (i = Y + 1; i < X;i++)
        {
            if( i % 2 != 0)
            {
                soma = i + soma;
            }

        }
                        printf("%d\n", soma);


    }

    else
    {
        for( i = X + 1; i <Y; i++)
        {
            if(i % 2 != 0)
            {
                soma = i + soma;
            }

        }
                        printf("%d\n", soma);


    }



        return 0;

}
