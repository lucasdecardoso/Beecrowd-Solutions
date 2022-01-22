#include <stdio.h>

int main()
{
    int i,aux = 0,valor;

    scanf("%d", &valor);

    for ( i = 1; i <= valor; i++)

    {
        aux = aux + 1;

        if( aux % 2 != 0)
            {
            printf("%d\n", aux);
            }
    }

    return 0;
}
