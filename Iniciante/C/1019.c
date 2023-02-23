#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{

    int N, horas, minutos, segundos, resto;

    scanf("%d", &N);

    minutos = N / 60;
    resto = N % 60;

    horas = minutos / 60;
    minutos = minutos % 60;
    segundos = resto;


    printf("%d:%d:%d\n", horas, minutos, segundos);


    return 0;
}
