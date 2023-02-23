#include <stdio.h>

int main() {

    double  SalFixo, TotalVendas, comissao, TOTAL;
    char nomevend[30];

    scanf("%s", nomevend);
    scanf("%lf %lf", &SalFixo, &TotalVendas);

    comissao = TotalVendas * 0.15;
    TOTAL = SalFixo + comissao;

    printf("TOTAL = R$ %0.2lf\n", TOTAL);

    return 0;
}
