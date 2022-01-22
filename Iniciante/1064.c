#include <stdio.h>

int main()
{
    float N, i, valor, soma = 0, peso = 0, media;

    for( i = 0; i < 6;)
    {
        scanf("%f", &valor);

        if(valor > 0)
        {
            soma = valor + soma;
            peso = peso + 1;

            i++;
        }
        else i++;

    }

    media = soma / peso;

    printf("%0.0f valores positivos\n", peso);
    printf("%0.1f\n", media);


        return 0;

}
