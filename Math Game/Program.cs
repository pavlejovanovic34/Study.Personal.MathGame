internal class Program
{
    private static void Main()
    {
        /*  PLAYERS DETAILS  */
        Console.WriteLine("Please type your name:");
        string name = Console.ReadLine();

        DateTime date = DateTime.Now; // datum i vreme pocetka igre

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

        if (gameSelected.Trim().ToLower() == "a")
        {
            AdditionGame("Addition game selected");
        }

        else if (gameSelected.Trim().ToLower() == "s")
        {
            SubtractionGame("Subtraction game selected");
        }

        else if (gameSelected.Trim().ToLower() == "m")
        {
            MultiplicationGame("Multiplication game selected");
        }

        else if (gameSelected.Trim().ToLower() == "d")
        {
            DivisionGame("Division game selected");
        }

        else if (gameSelected.Trim().ToLower() == "q")
        {
            ExitGame("Goodbye");
        }

        else
        {
            Console.WriteLine("Invalid input");
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