namespace MathGameLibrary
{
    public class Menu
    {
        GameEngine engine = new GameEngine();

        private static readonly DateTime date = DateTime.Now; // datum i vreme pocetka igre
        public void MainMenu(string name)
        {
            /* GREETING AND MAIN MENU */
            Console.Clear();
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself");
            Console.WriteLine("Press any key to show menu");
            Console.ReadKey();
            Console.Clear();


            bool isGameOn = true;

            do
            {
                Console.WriteLine(@$"What game would you like to play today? Choose from the options below: 
        V - View Previous Games
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Divison
        R - Random game    
        Q - Quit the program
        ");
                Console.WriteLine("------------------------------------------------------------");

                string gameSelected = Console.ReadLine();

                while(string.IsNullOrEmpty(gameSelected))
                {
                    Console.WriteLine("Your need to choose some of the options in the menu. Please try again.");
                    gameSelected = Console.ReadLine();
                }

                /* CHOOSING A RIGHT GAME */
                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;

                    case "a":
                        engine.AdditionGame("Addition game");
                        break;

                    case "s":
                        engine.SubtractionGame("Subtraction game");
                        break;

                    case "m":
                        engine.MultiplicationGame("Multiplication game");
                        break;

                    case "d":
                        engine.DivisionGame("Division game");
                        break;

                    case "r":
                        engine.RandomGame("Random game");
                        break;

                    case "q":   
                        isGameOn = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.Clear();

            } 
            while (isGameOn == true);

            Console.Clear();
            Console.WriteLine("Thank you for playing Math game.");
        }

        internal static int[] LevelMenu(int numOfQuestions, out string difficulty)
        {
            Console.Clear();

            int[] numbers = new int[numOfQuestions * 2];

            Console.WriteLine(@$"Please select difficulty of the game: Choose from the options below: 
        E - Easy level
        M - Intermediate level
        H - Hard level
        ");

            difficulty = null;

            string gameLevel = Console.ReadLine();

            while (string.IsNullOrEmpty(gameLevel))
            {
                Console.WriteLine("Your need to choose some of the options in the menu. Please try again.");
                Console.Write("Your choice: ");
                gameLevel = Console.ReadLine();
            }

            bool emptyNumbers = false; 

            switch(gameLevel.Trim().ToLower()) 
            {
                case "e":
                    numbers = LevelOfDificulty.Easy(numOfQuestions);
                    difficulty = "Easy";
                    break;

                case "m":
                    numbers = LevelOfDificulty.Medium(numOfQuestions);
                    difficulty = "Medium";
                    break;

                case "h":
                    numbers = LevelOfDificulty.Hard(numOfQuestions);
                    difficulty = "Hard";
                    break;

                default:
                    emptyNumbers = true;                    
                    break;
            }

            if(emptyNumbers == true)
            {
              Console.WriteLine("Select one of the options above. Press any key to continue.");
              Console.ReadKey();
  
              numbers = LevelMenu(numOfQuestions, out difficulty);
            }

            return numbers;
        }
    }
}