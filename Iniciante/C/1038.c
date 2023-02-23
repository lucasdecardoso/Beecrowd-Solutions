#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    float codigo, quantidade;
    float total;

    scanf("%f", &codigo);

    if ( codigo == 1)
    {
        scanf("%f", &quantidade);

        total = quantidade * 4.00;
        printf("Total: R$ %0.2f\n", total);


    }

    else if ( codigo == 2)
    {
        scanf("%f", &quantidade);

        total = quantidade * 4.50;
        printf("Total: R$ %0.2f\n", total);

    }
    else if ( codigo == 3)
    {
        scanf("%f", &quantidade);

        total = quantidade * 5.00;
        printf("Total: R$ %0.2f\n", total);

    }
    else if ( codigo == 4)
    {
        scanf("%f", &quantidade);

        total = quantidade * 2.00;
        printf("Total: R$ %0.2f\n", total);

    }
    else     {
        scanf("%f", &quantidade);

        total = quantidade * 1.50;
        printf("Total: R$ %0.2f\n", total);

    }




    return 0;
}
