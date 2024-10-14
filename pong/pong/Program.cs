using System.Runtime.InteropServices.Marshalling;
using System.Security.Principal;

internal class Program
{
    private static void Main(string[] args)
    {
       bool gameOver=false;
       int Width = Console.WindowWidth -1 ;
       int Height = Console.WindowHeight -1;
       int x =3, y = 3, xv = 1, yv = 1;

            while (!gameOver)
        {
            //Input verwerken 
            //Update game 
            x += xv;
            y += yv;
            if (x + xv >= Width || x <= 0 )
            {
                    xv = -xv;
            }
            if (y + yv >= Height || y <= 0)
            {
                    yv = -yv; 
            } 
            //Render (Console.Write/Console.WriteLine)
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;               
            Console.CursorVisible = false;
            Console.SetCursorPosition(x,y);
            Console.WriteLine("O");    
                
            //Wait
            System.Threading.Thread.Sleep(50);    
                    

            }
    }
}