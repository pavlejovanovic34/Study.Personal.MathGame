namespace MathGameLibrary
{
    public class Menu
    {
        GameEngine engine = new GameEngine();

        private static readonly DateTime date = DateTime.Now; // datum i vreme pocetka igre
        public void MainMenu(string name)
        {
            /* GREETING AND MAIN MENU */
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself\n");

            bool isGameOn = true;

            do
            {
                Console.WriteLine(@$"What game would you like to play today? Choose from the options below: 
        V - View Previous Games
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
                    case "v":
                        Helpers.GetGames();
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
    }
}