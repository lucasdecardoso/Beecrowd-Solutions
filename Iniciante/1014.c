#include <stdio.h>

int main() {

    int X;
    double Y, total;


    scanf("%d", &X);
    scanf("%lf", &Y);

    total = X / Y;

    printf("%0.3lf km/l\n", total);



    return 0;
}
