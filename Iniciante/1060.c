#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    float A,B,C,D,E,F;
    float i = 0;


        scanf("%f %f %f %f %f %f", &A, &B, &C, &D, &E, &F);


        if (A > 0)
        {
            i = i + 1;
        }

        else i = i+0;

            if (B > 0)
        {
            i = i + 1;
        }

        else i = i+0;


        if (C > 0)
        {
            i = i + 1;
        }

        else i = i+0;


        if (D > 0)
        {
            i = i + 1;
        }

        else i = i+0;


        if (E > 0)
        {
            i = i + 1;
        }

        else i = i+0;


        if (F > 0)
        {
            i = i + 1;
        }

        else i = i+0;




    printf("%0.0f valores positivos\n", i);

    return 0;
}
