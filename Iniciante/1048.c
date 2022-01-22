#include <stdio.h>

int main()
{

    float salario, reajuste, percentual;

    scanf("%f", &salario);

    if (salario >= 0 && salario <= 400.00)
    {
        reajuste =  salario * 15 / 100;
        percentual = reajuste + salario;

        printf("Novo salario: %0.2f\n", percentual);
        printf("Reajuste ganho: %0.2f\n", reajuste);
        printf("Em percentual: 15 %%\n");


    }

    else if (salario >= 400.01 && salario <= 800.00)
    {
        reajuste =  salario * 12 / 100;
        percentual = reajuste + salario;

        printf("Novo salario: %0.2f\n", percentual);
        printf("Reajuste ganho: %0.2f\n", reajuste);
        printf("Em percentual: 12 %%\n");


    }
    else if (salario >= 800.01 && salario <= 1200.00)
    {
        reajuste =  salario * 10 / 100;
        percentual = reajuste + salario;

        printf("Novo salario: %0.2f\n", percentual);
        printf("Reajuste ganho: %0.2f\n", reajuste);
        printf("Em percentual: 10 %%\n");


    }


    else if (salario >= 1200.01 && salario <= 2000.00)
    {
        reajuste =  salario * 7 / 100;
        percentual = reajuste + salario;

        printf("Novo salario: %0.2f\n", percentual);
        printf("Reajuste ganho: %0.2f\n", reajuste);
        printf("Em percentual: 7 %%\n");


    }
    else if (salario >= 2000.01)
    {
        reajuste =  salario * 4 / 100;
        percentual = reajuste + salario;

        printf("Novo salario: %0.2f\n", percentual);
        printf("Reajuste ganho: %0.2f\n", reajuste);
        printf("Em percentual: 4 %%\n");


    }



    return 0;

}
