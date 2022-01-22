#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{

    float velomedia, tempogasto;
    float total;

    scanf("%f %f", &tempogasto, &velomedia);

    total = (velomedia * tempogasto) / 12;

    printf("%0.3f\n", total);

  
    return 0;
}
