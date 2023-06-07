using MathGameLibrary.Models;
using System.Net.Http.Headers;

namespace MathGameLibrary
{
    public class Helpers
    {
       

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
                    Console.WriteLine($"{game.Date} - {game.Type}: Game Difficulty = {game.Difficulty}, Elapsed Time: {game.TimeElapesd.Seconds} seconds, Number of questions: {game.NumOfQuestions}, Score = {game.Score}pts");
                }
            }

            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("Press any key to get back to main menu.");
            Console.ReadKey();
        }

        internal static void AddToHistory(int gameScore, GameType gameType, string difficulty, TimeSpan elapsedTime, int numOfQuestions)
        {
            games.Add(new Game 
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
                Difficulty = difficulty,
                TimeElapesd = elapsedTime,
                NumOfQuestions = numOfQuestions
            });
        }


        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.Clear();
                Console.WriteLine("Your input must be an integer. Try again.");
                Console.Write("Your answer: ");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static string? ValidateDivisonResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Double.TryParse(result, out _))
            {
                Console.Clear();
                Console.WriteLine("Your input must be a number. Try again.");
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

        internal static void ValidateDifficultyLevelInput(int[] numbers)
        {
            if(numbers == null)
            {
                Console.WriteLine("Invalid input. Please try again!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

                Console.Clear();


                string name = Helpers.GetName();
                Menu menu = new Menu();
                menu.MainMenu(name);
            }
        }

        internal static int NumberOfQuestionsInput()
        {
            Console.WriteLine("Please select number of questions for the game: ");
            string numOfQuestions = Console.ReadLine();

            numOfQuestions = Helpers.ValidateResult(numOfQuestions);

            return int.Parse(numOfQuestions);
        }

        internal static int CheckAnwer(int operandOne,int operandTwo, int result, string operand)
        {
            int correctAnswer = 0;
            int score = 0;

            switch(operand.Trim().ToLower()) 
            {
                case "+":
                    correctAnswer = operandOne + operandTwo;
                    break;

                case "-":
                    correctAnswer = operandOne - operandTwo;
                    break;
                    
                case "*":
                    correctAnswer = operandOne * operandTwo; 
                    break;
            }

            if(result == correctAnswer)
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

            return score;
        }

        internal static int CheckDivisonAnswer(int operandOne, int operandTwo, double result) 
        {
            double correctAnswer = (double)operandOne / (double)operandTwo;

            int score = 0;

            if(Math.Round(result,2) == correctAnswer)
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

            return score;
        }

    }
}
