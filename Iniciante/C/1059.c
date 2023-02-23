#include <stdio.h>

int main()
{
    int i,aux = 0;

    for ( i = 1; i <= 100; i++)

    {
        aux = aux + 1;

        if( aux % 2 == 0)
            {
            printf("%d\n", aux);
            }
    }

    return 0;
}
