using MathGameLibrary.Models;
namespace MathGameLibrary
{
    internal class GameEngine
    {
        
        internal void AdditionGame(string message)
        {
            Console.Clear(); // clear the console window
            Console.WriteLine(message);

            Console.WriteLine("Please select number of questions for the game: ");
            string numOfQuestions = Console.ReadLine();
            
            numOfQuestions = Helpers.ValidateResult(numOfQuestions);


            int[] numbers = Menu.LevelMenu(int.Parse(numOfQuestions), out string difficulty);
            
            /* VALIDATION */
            if (numbers == null)
            {
                Helpers.ValidateDifficultyLevelInput(numbers);
            }

            else
            {
                int score = 0;
                Console.Clear();


                for (int i = 0; i < numbers.Length / 2; i += 2)
                {

                    Console.WriteLine($"{i + 1}. example: {numbers[i]} + {numbers[i + 1]}");
                    Console.Write("Your answer: ");
                    var result = Console.ReadLine();

                    // validation
                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == numbers[i] + numbers[i + 1])
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

                Helpers.AddToHistory(score, GameType.Addition, difficulty);
                Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
                Console.ReadKey();
            }

           
        }


        
        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            Console.WriteLine("Please select number of questions for the game: ");
            string numOfQuestions = Console.ReadLine();

            numOfQuestions = Helpers.ValidateResult(numOfQuestions);

            int[] numbers = Menu.LevelMenu(int.Parse(numOfQuestions), out string difficulty);
            
            /* VALIDATION */

            if (numbers == null)
            {
                Helpers.ValidateDifficultyLevelInput(numbers);
            }

            else
            {
                Console.Clear();

                int score = 0;



                for (int i = 0; i < numbers.Length / 2; i += 2)
                {

                    Console.WriteLine($"{i + 1}. example: {numbers[i]} - {numbers[i + 1]}");
                    Console.Write("Your answer: ");
                    var result = Console.ReadLine();

                    // validation
                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == numbers[i] - numbers[i + 1])
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

                Helpers.AddToHistory(score, GameType.Subtraction, difficulty);
                Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
                Console.ReadKey();
            }
        }

        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            Console.WriteLine("Please select number of questions for the game: ");
            string numOfQuestions = Console.ReadLine();

            numOfQuestions = Helpers.ValidateResult(numOfQuestions);



            int[] numbers = Menu.LevelMenu(int.Parse(numOfQuestions), out string difficulty);

            /* VALIDATION */

            if (numbers == null)
            {
                Helpers.ValidateDifficultyLevelInput(numbers);
            }

            else
            {
                int score = 0;

                Console.Clear();


                for (int i = 0; i < numbers.Length / 2; i += 2)
                {

                    Console.WriteLine($"{i + 1}. example: {numbers[i]} * {numbers[i + 1]}");
                    Console.Write("Your answer: ");
                    var result = Console.ReadLine();

                    // validation
                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == numbers[i] * numbers[i + 1])
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
                Console.Clear();


                Helpers.AddToHistory(score, GameType.Multiplication, difficulty);
                Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
                Console.ReadKey();
            }
            
        }
        


        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            Console.WriteLine("Please select number of questions for the game: ");
            string numOfQuestions = Console.ReadLine();

            numOfQuestions = Helpers.ValidateResult(numOfQuestions);

            
            int[] numbers = Menu.LevelMenu(int.Parse(numOfQuestions), out string difficulty);

            /* VALIDATION */

            if (numbers == null)
            {
                Helpers.ValidateDifficultyLevelInput(numbers);
            }

            else
            {
                int score = 0;

                Console.Clear();

                for (int i = 0; i < numbers.Length / 2; i++)
                {
                    //var divisionNumbers = Helpers.GetDivisionNumbers();
                    Console.WriteLine($"{i + 1}. example: {numbers[i]} / {numbers[i + 1]}\nOnly results with 2 decimals will be accepted");
                    Console.Write("Your answer: ");
                    var result = Console.ReadLine();

                    // validation
                    result = Helpers.ValidateDivisonResult(result);
                    
                    double quotient = double.Parse(result);
                    
                    double correctAnswer = (double)numbers[i] / (double)numbers[i + 1];

                    if (quotient == Math.Round(correctAnswer, 2))
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

                Helpers.AddToHistory(score, GameType.Division, difficulty);
                Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
                Console.ReadKey();
            }
          
        }
    }
}
