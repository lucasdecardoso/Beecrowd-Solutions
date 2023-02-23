#include <stdio.h>

int main()
{
    int X, i, valor, dentro = 0, temer = 0;

    scanf("%d", &X);

    for( i = X; i <= X + 12; i++)
    {

        if(i % 2 != 0)
        {
            printf("%d\n", i);

        }


    }



        return 0;

}
