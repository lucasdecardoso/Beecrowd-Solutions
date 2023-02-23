#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main() {

    int dias, mes, anos, resto;


    scanf("%d", &dias);


    anos = dias /365;
    resto = dias % 365;
    mes = resto / 30;
    resto = resto % 30;



    printf("%d ano(s)\n", anos);
    printf("%d mes(es)\n", mes);
    printf("%d dia(s)\n", resto);



    return 0;
}
