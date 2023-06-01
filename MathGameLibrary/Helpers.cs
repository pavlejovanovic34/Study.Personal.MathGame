

namespace MathGameLibrary
{
    internal class Helpers
    {
        private static readonly List<string> games = new List<string>(); // keeps history of games being played
        internal static void GetGames()
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
                foreach (string game in games)
                {
                    Console.WriteLine($"{game}");
                }
            }

            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("Press any key to get back to main menu.");
            Console.ReadKey();
        }

        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score = {gameScore}");
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
