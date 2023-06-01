using MathGameLibrary.Models;

namespace MathGameLibrary
{
    public class Helpers
    {
        /*
        private static readonly List<Game> games = new List<Game>
        {
            new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 }
        }; // keeps history of games being played -- predef games -- lorem ipsum --
        */

        private static readonly List<Game> games = new List<Game>();
        internal static void PrintGames()
        {
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2023, 06, 10) && x.Score > 3).OrderByDescending(x => x.Date); //LINQ query

            Console.Clear();
            Console.WriteLine("Games history");
            Console.WriteLine("---------------------------------");

            if (games.Count == 0)
            {
                Console.WriteLine("You haven't played any game yet!");
            }

            else
            {
                foreach (Game game in games)
                {
                    Console.WriteLine($"{game.Date} - {game.Type}: Score = {game.Score}pts");
                }
            }

            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("Press any key to get back to main menu.");
            Console.ReadKey();
        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game 
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }

        internal static int[] GetDivisionNumbers()
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

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your input must ne an integer. Try again.");
                Console.Write("Your answer: ");
                result = Console.ReadLine();
            }

            return result;
        }

        public static string GetName()   /*  PLAYERS DETAILS  */
        {
            Console.WriteLine("Please type your name:");
            string name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You need to enter your name. Try again.");
                name = Console.ReadLine();
            }

            return name;
        }
    }
}
