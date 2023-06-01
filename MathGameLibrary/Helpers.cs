using MathGameLibrary.Models;

namespace MathGameLibrary
{
    internal class Helpers
    {
        private static readonly List<Game> games = new List<Game>(); // keeps history of games being played
        internal static void PrintGames()
        {
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
    }
}
