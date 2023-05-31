using static System.Formats.Asn1.AsnWriter;

internal class Program
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

        bool isGameOn = true;
        
        do
        {
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
                    AdditionGame("Addition game");
                    break;

                case "s":
                    SubtractionGame("Subtraction game");
                    break;

                case "m":
                    MultiplicationGame("Multiplication game");
                    break;

                case "d":
                    DivisionGame("Division game");
                    break;

                case "q":
                    isGameOn = false;
                    ExitGame("Thankk you for playing Math game.");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    Environment.Exit(1);
                    break;
            }
        }
        while (isGameOn == true);
    }

    static void AdditionGame(string message)
    {
        Console.Clear(); // clear the console window
        Console.WriteLine(message);

        Random random = new Random();

        int firstNumber;
        int secondNumber;
        int score = 0;

        for (int i = 0; i < 5; i++)
        {
            

            firstNumber = random.Next(1, 10); // 1 <= broj < 10
            secondNumber = random.Next(1, 10);

            Console.WriteLine($"{i+1}. example: {firstNumber} + {secondNumber}");
            Console.Write("Your answer: ");
            var result = Console.ReadLine();

            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("Your answer is correct! Type any key to continue");
                score++;
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Your answer is incorrect! Type any key to continue");
                Console.ReadLine();
            }
            Console.Clear();
        }

        Console.WriteLine($"\nYour final score is: {score}\nPress any key to go back to main menu.");
        Console.ReadKey();
    }

    static void SubtractionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        Random random = new Random();

        int firstNumber;
        int secondNumber;
        int score = 0;

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, 10); // 1 <= broj < 10
            secondNumber = random.Next(1, 10);

            Console.WriteLine($"\n{i + 1}. example: {firstNumber} - {secondNumber}");
            Console.Write("Your answer: ");
            var result = Console.ReadLine();

            if (int.Parse(result) == firstNumber - secondNumber)
            {
                Console.WriteLine("Your answer is correct! Type any key to continue");
                score++;
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Your answer is incorrect! Type any key to continue");
                Console.ReadKey();
            }
            Console.Clear();
        }
            Console.WriteLine($"\nYour score is: {score}\nPress any key to go back to main menu.");
        Console.ReadKey();
    }

    static void MultiplicationGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        Random random = new Random();

        int firstNumber;
        int secondNumber;
        int score = 0;

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, 10); // 1 <= broj < 10
            secondNumber = random.Next(1, 10);

            Console.WriteLine($"\n{i + 1}. example: {firstNumber} * {secondNumber}");
            Console.Write("Your answer: ");
            var result = Console.ReadLine();

            if (int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine("Your answer is correct! Type any key to continue");
                score++;
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Your answer is incorrect! Type any key to continue");
                Console.ReadLine();
            }
            Console.Clear();
        }
            Console.WriteLine($"\nYour final score is: {score}\nPress any key to go back to main menu.");
            Console.ReadKey();
    }

    static void DivisionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        int score = 0;

        for(int i = 0; i < 5; i++) 
        {
            var divisionNumbers = GetDivisionNumbers();
            Console.WriteLine($"\n{i + 1}. example: {divisionNumbers[0]} / {divisionNumbers[1]}");
            Console.Write("Your answer: ");
            var result = Console.ReadLine();

            if (int.Parse(result) == divisionNumbers[0] / divisionNumbers[1])
            {
                Console.WriteLine("Your answer is correct! Type any key to continue");
                score++;
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Your answer is incorrect! Type any key to continue");
                Console.ReadLine();
            }
            Console.Clear();
        }
        Console.WriteLine($"\nYour final score is: {score}\nPress any key to go back to main menu.");
        Console.ReadKey();
    }


    static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var firstNmber = random.Next(0, 99);
        var secondNmber = random.Next(1, 99);

        while (firstNmber % secondNmber != 0)
        {
            firstNmber = random.Next(0, 99);
            secondNmber = random.Next(1, 99);
        }

        return new int[2] { firstNmber, secondNmber };
    }
    static void ExitGame(string message)
    {
        Console.WriteLine(message);
        Environment.Exit(1); // Prekida rad programa i salje exit code(1) sto znaci da je korisnik sam izabrao da ugasi program
    }
}