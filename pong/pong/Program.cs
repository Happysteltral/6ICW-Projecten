using System.Runtime.InteropServices.Marshalling;

internal class Program
{
    private static void Main(string[] args)
    {
       bool gameOver=false;
       int balx=0,baly=0;
            while (!gameOver)
        {
                //Input verwerken 
                //Update game 
                //Render (Console.Write/Console.WriteLine)
                // Console.WindowWidth
                
                Console.CursorVisible = false;
                Console.SetCursorPosition(balx,baly);
                Console.WriteLine("O");
                //Wait
                System.Threading.Thread.Sleep(50);
                Console.Clear();

            }
    }
}