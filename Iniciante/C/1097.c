#include <stdio.h>

int main() 
{
 
    int num1 = 1, num2 = 7, i, j;
  
    volta:

    do
    {

        for( i = 1; i <=3; i++)
        {
            printf("I=%d J=%d\n",num1, num2);
            num2 = num2 - 1;
            
        
        }
    
        
        i = 1;
        num1 = num1 + 2;
        num2 = num2 + 5;
        
    }

    while (num1 != 11);
  
    

    return 0;
}
