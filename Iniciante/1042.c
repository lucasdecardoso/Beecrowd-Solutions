#include <stdio.h>

int main()
{
    int a, b, c;
    int valores[3];
    
    scanf("%d %d %d", &a, &b, &c);
    valores[0] = a;
    valores[1] = b;
    valores[2] = c;
    
    if(valores[0] < valores[1] && valores[0] < valores[2])
    {
        printf("%d\n", valores[0]);
        
        if(valores[1] <valores[2])
        {
            printf("%d\n", valores[1]);
            printf("%d\n",valores[2]);
        }    
        else
        {
            printf("%d\n", valores[2]);
            printf("%d\n",valores[1]);
        }    
            
        
    }
    
    else if(valores[1] < valores[0] && valores[1] < valores[2])
    {
        printf("%d\n", valores[1]);
        
        if(valores[0] < valores[2])
        {
            printf("%d\n", valores[0]);
            printf("%d\n",valores[2]);
        }
        else
        {
            printf("%d\n", valores[2]);
            printf("%d\n",valores[0]);
        }
        
    }
    
    else if(valores[2] < valores[0] && valores[2] < valores[1])
    {
        printf("%d\n", valores[2]);
        
        if(valores[0] < valores[1])
        { 
            printf("%d\n", valores[0]);
            printf("%d\n",valores[1]);
        }
        else
        {
            printf("%d\n", valores[1]);
            printf("%d\n",valores[0]);
        }

    }
    
    printf("\n%d\n%d\n%d\n", valores[0], valores[1], valores[2]);
    
    
    

    return 0;
}
