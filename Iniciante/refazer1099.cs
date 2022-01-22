using System; 

class URI 
{

    static void Main(string[] args) 
    { 
        int i = 0;
    	int imparTotal = 0;

		int N = Convert.ToInt32(Console.ReadLine());

        while(i < N)
        {   
            string[] numbers = Console.ReadLine().Split();
		    int X = Convert.ToInt32(numbers[0]);
		    int Y = Convert.ToInt32(numbers[1]);

            imparTotal = 0;

            if ( X == Y || X - Y == 1 || Y - X == 1 )
            {
		        Console.WriteLine("0");
            }
            else if ( X > Y) // 5 e 2
            {
                for (Y = Y + 1; Y < X; Y++)
                {
                    if (Y % 2 == 1)
                    {
                        imparTotal = imparTotal + Y;
                    }
                
                }   
		        Console.WriteLine(imparTotal);
            }
            else if ( Y > X) // 3 e 5
            {
                for (X = X + 1; X < Y; X++)
                {
                    if (X % 2 == 1)
                    {
                        imparTotal = imparTotal + X;
                    }
                

                }
			    Console.WriteLine(imparTotal);

            }
            else
            {
			    Console.WriteLine("invalido");
	        }
        
              
        
            i++;
        }
        
    }
    
}

        

