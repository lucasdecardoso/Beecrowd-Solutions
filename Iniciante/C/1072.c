#include <stdio.h>

int main()
{
    int N, i, valor, dentro = 0, temer = 0;

    scanf("%d", &N);

    for( i = 0; i < N; i++)
    {
        scanf("%d", &valor);

        if(valor >= 10 && valor <= 20)
        {
            dentro = dentro + 1;


        }

        else temer = temer + 1;

    }


    printf("%d in\n", dentro);
    printf("%d out\n", temer);


        return 0;

}
