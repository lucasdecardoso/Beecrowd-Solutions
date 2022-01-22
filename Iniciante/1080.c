#include <stdio.h>

int main()
{
 int maior = 0,i, valor, posicao;

    for ( i = 1; i <= 100; i++)
    {
        scanf("%d", &valor);

        if( valor >= maior)
        {
            maior = valor;
            posicao = i;


        }


    }

    printf("%d\n", maior);
    printf("%d\n", posicao);



    return 0;

}
