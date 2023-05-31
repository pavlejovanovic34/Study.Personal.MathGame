﻿internal class Program
{
    private static void Main()
    {
      

        DateTime date = DateTime.Now; // datum i vreme pocetka igre

        string name = GetName(); 

        

        MainMenu(name, date);
    }

     static string GetName()   /*  PLAYERS DETAILS  */
    {
        Console.WriteLine("Please type your name:");
        return Console.ReadLine();
    }

    static void MainMenu(string name, DateTime date)
    {
        /* GREETING AND MAIN MENU */
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself\n");

        Console.WriteLine(@$"What game would you like to play today? Choose from the options below: 
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Divison    
        Q - Quit the program
        ");
        Console.WriteLine("------------------------------------------------------------");

        string gameSelected = Console.ReadLine();

        /* CHOOSING A RIGHT GAME */
        switch (gameSelected.Trim().ToLower())
        {
            case "a":
                AdditionGame("Addition game selected");
                break;

            case "s":
                SubtractionGame("Subtraction game selected");
                break;

            case "m":
                MultiplicationGame("Multiplication game selected");
                break;

            case "d":
                DivisionGame("Division game selected");
                break;

            case "q":
                ExitGame("Goodbye");
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    static void AdditionGame(string message)
    {
        Console.WriteLine(message);
    }

    static void SubtractionGame(string message)
    { 
        Console.WriteLine(message);
    }

    static void MultiplicationGame(string message)
    {
        Console.WriteLine(message);
    }

    static void DivisionGame(string message)
    {
        Console.WriteLine(message);
    }

    static void ExitGame(string message)
    {
        Console.WriteLine(message);
        Environment.Exit(1); // Prekida rad programa i salje exit code(1) sto znaci da je korisnik sam izabrao da ugasi programom
    }
}