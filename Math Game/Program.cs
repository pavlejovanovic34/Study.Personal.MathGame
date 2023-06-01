using MathGameLibrary;


internal class Program
{
   
    private static void Main()
    {
        string name = GetName();

       Menu menu = new Menu();
       
       menu.MainMenu(name);   

        
    }

    static string GetName()   /*  PLAYERS DETAILS  */
    {
        Console.WriteLine("Please type your name:");
        return Console.ReadLine();
    }
}