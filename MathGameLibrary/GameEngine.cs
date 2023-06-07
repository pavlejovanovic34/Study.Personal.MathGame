using MathGameLibrary.Models;
using System.Diagnostics;

namespace MathGameLibrary
{
    internal class GameEngine
    {
        
       internal void AdditionGame(string message)
        {
            Console.Clear(); // clear the console window
            Console.WriteLine(message);

            int numOfQuestions = Helpers.NumberOfQuestionsInput();

            int[] numbers = Menu.LevelMenu(numOfQuestions, out string difficulty);
            
            // VALIDATION 
            if (numbers == null)
            {
                Helpers.ValidateDifficultyLevelInput(numbers);
            }

            else
            {
                int score = 0;
                Console.Clear();

                // starting to count time
                Stopwatch stopwatch = Stopwatch.StartNew();

                for (int i = 0; i < numbers.Length; i+=2)
                {

                    Console.WriteLine($"Example: {numbers[i]} + {numbers[i + 1]}");
                    Console.Write("Your answer: ");
                    var result = Console.ReadLine();

                    // validation
                    result = Helpers.ValidateResult(result);

                    score += Helpers.CheckAnwer(numbers[i], numbers[i + 1], int.Parse(result), "+");

                    Console.Clear();
                }

                // stopping the stopwatch
                stopwatch.Stop();

                // adding time that user spent to answer the questions of the game
                TimeSpan elapsedTime = stopwatch.Elapsed;

                Helpers.AddToHistory(score, GameType.Addition, difficulty, elapsedTime, numOfQuestions);
                Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
                Console.ReadKey();
            }

           
        }


        
        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int numOfQuestions = Helpers.NumberOfQuestionsInput();

            int[] numbers = Menu.LevelMenu(numOfQuestions, out string difficulty);
            
            // VALIDATION 

            if (numbers == null)
            {
                Helpers.ValidateDifficultyLevelInput(numbers);
            }

            else
            {
                Console.Clear();

                int score = 0;

                Stopwatch stopwatch = Stopwatch.StartNew();

                for (int i = 0; i < numbers.Length; i+=2)
                {

                    Console.WriteLine($"Example: {numbers[i]} - {numbers[i + 1]}");
                    Console.Write("Your answer: ");
                    var result = Console.ReadLine();

                    // validation
                    result = Helpers.ValidateResult(result);

                    score += Helpers.CheckAnwer(numbers[i], numbers[i + 1], int.Parse(result), "-");

                    Console.Clear();
                }

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;

                Helpers.AddToHistory(score, GameType.Subtraction, difficulty, elapsedTime, numOfQuestions);
                Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
                Console.ReadKey();
            }
        }

        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int numOfQuestions = Helpers.NumberOfQuestionsInput();

            int[] numbers = Menu.LevelMenu(numOfQuestions, out string difficulty);

            // VALIDATION 

            if (numbers == null)
            {
                Helpers.ValidateDifficultyLevelInput(numbers);
            }

            else
            {
                int score = 0;

                Console.Clear();

                Stopwatch stopwatch = Stopwatch.StartNew();

                for (int i = 0; i < numbers.Length; i+=2)
                {

                    Console.WriteLine($"Example: {numbers[i]} * {numbers[i + 1]}");
                    Console.Write("Your answer: ");
                   var result = Console.ReadLine();

                    // validation
                    result = Helpers.ValidateResult(result);

                    score += Helpers.CheckAnwer(numbers[i], numbers[i + 1], int.Parse(result), "*");

                    Console.Clear();
                }
                
                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;

                Helpers.AddToHistory(score, GameType.Multiplication, difficulty, elapsedTime, numOfQuestions);
                Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
                Console.ReadKey();
            }
            
        }
        
        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int numOfQuestions = Helpers.NumberOfQuestionsInput();

            int[] numbers = Menu.LevelMenu(numOfQuestions, out string difficulty);

            // VALIDATION 

            if (numbers == null)
            {
                Helpers.ValidateDifficultyLevelInput(numbers);
            }

            else
            {
                int score = 0;

                Console.Clear();

                Stopwatch stopwatch = Stopwatch.StartNew();

                for (int i = 0; i < numbers.Length; i+=2)
                {
                    
                    Console.WriteLine($"Example: {numbers[i]} / {numbers[i + 1]}\nOnly results rounded up to 2 decimals will be accepted");
                    Console.Write("Your answer: ");
                    var result = Console.ReadLine();

                    // validation
                    result = Helpers.ValidateDivisonResult(result);

                    score += Helpers.CheckDivisonAnswer(numbers[i], numbers[i + 1], double.Parse(result));
                    
                    Console.Clear();
                }

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;

                Helpers.AddToHistory(score, GameType.Division, difficulty, elapsedTime, numOfQuestions);
                Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
                Console.ReadKey();
            }
          
        }


        internal void RandomGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int[] numbers = Menu.LevelMenu(4, out string gameLevel);

            int score = 0;
            int i = 0;
           

            Stopwatch stopwatch = Stopwatch.StartNew();

            // calling each game type once
            score += RandomGameGenerator.Addition(numbers[i], numbers[i + 1]);
            i += 2;

            score += RandomGameGenerator.Subtraction(numbers[i], numbers[i + 1]);
            i += 2;

            score += RandomGameGenerator.Multiplication(numbers[i], numbers[i + 1]);
            i += 2;

            score += RandomGameGenerator.Division(numbers[i], numbers[i + 1]);
            i += 2;


            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            Helpers.AddToHistory(score, GameType.RandomGame, gameLevel , elapsedTime, 4);
            Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
            Console.ReadKey();
        }
    }
}
