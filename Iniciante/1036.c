#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{

    double A, B, C, delta, r1, r2;

    scanf("%lf %lf %lf", &A, &B, &C);

    delta = (B*B) - (4*A*C);

     if (A < 1 || B < 1 || C < 1 || delta < 1)
     {

            printf("Impossivel calcular\n");

    }
     else

    {
            delta = sqrt(delta);

            r1 = ((-1 * B) + delta) / (2 * A);

            r2 = ((-1 * B) - delta) / (2 * A);

            printf("R1 = %0.5lf\n", r1);
            printf("R2 = %0.5lf\n", r2);

    }


    return 0;
}
