#include <stdio.h>

int main() {
    
    int N, X, Y, contador = 0, i = 0, imparTotal;
   
    scanf("%d", &N); //casos de teste
    
    do
    {
        scanf("%d %d", &X, &Y);
        imparTotal = 0;
        
        if( X == Y)
        {
            printf("%d\n", imparTotal);

        }
        
        else if(X < Y)
        {
            for(i = X + 1; i < Y; i++)
            {
                if(i % 2 == 1 )
                {
                    imparTotal = imparTotal + i;
                    
                }
            }
            printf("%d\n", imparTotal);
        }   
        else if(Y < X)
        {
            for(i = Y + 1; i < X; i++)
            {
                if(i % 2 == 1 )
                {
                    imparTotal = imparTotal + i;
                }
            }
            printf("%d\n", imparTotal);
        }
    
        
        contador = contador + 1;
    }while(contador < N);
    

    return 0;
}
        

