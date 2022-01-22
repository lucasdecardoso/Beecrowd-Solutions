#include <stdio.h>

int main() {

    double A, B, C;
    double AreaTria, AreaCirc, AreaTrap, AreaQuad, AreaRetang;

    scanf("%lf %lf %lf", &A, &B, &C);

    AreaTria = (A*C) / 2;
    AreaCirc = 3.14159 * (C * C);
    AreaTrap = ( (A+B) * C )  / 2;
    AreaQuad = B * B;
    AreaRetang = A * B;

    printf("TRIANGULO: %0.3lf\n", AreaTria);
    printf("CIRCULO: %0.3lf\n", AreaCirc);
    printf("TRAPEZIO: %0.3lf\n", AreaTrap);
    printf("QUADRADO: %0.3lf\n", AreaQuad);
    printf("RETANGULO: %0.3lf\n", AreaRetang);

    return 0;
}
