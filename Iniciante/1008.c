#include <stdio.h>

int main() {

    int  NUMBER,HOURS;
    float SALARYPH, SALARY;

    scanf("%d %d", &NUMBER, &HOURS);
    scanf("%f", &SALARYPH);

    SALARY = SALARYPH * HOURS;


    printf("NUMBER = %d\n", NUMBER);
    printf("SALARY = U$ %0.2f\n", SALARY);

    return 0;
}
