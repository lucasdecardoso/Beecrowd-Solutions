#include <stdio.h>

int main() {

    int codp1, codp2, quantp1, quantp2;

    float valorp1, valorp2, TOTAL;

    scanf("%d %d", &codp1, &quantp1);
    scanf("%f", &valorp1);
    scanf("%d %d", &codp2, &quantp2);
    scanf("%f", &valorp2);


    TOTAL = (quantp1 * valorp1) + (quantp2 * valorp2);

    printf("VALOR A PAGAR: R$ %0.2lf\n", TOTAL);

    return 0;
}
