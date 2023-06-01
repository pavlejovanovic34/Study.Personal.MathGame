namespace MathGameLibrary
{
    internal class GameEngine
    {
        
        internal void AdditionGame(string message)
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

                Console.WriteLine($"{i + 1}. example: {firstNumber} + {secondNumber}");
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

            Helpers.AddToHistory(score, "Addition");
            Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
            Console.ReadKey();
        }

        internal void SubtractionGame(string message)
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

                Console.WriteLine($"{i + 1}. example: {firstNumber} - {secondNumber}");
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

            Helpers.AddToHistory(score, "Subtraction");
            Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
            Console.ReadKey();
        }

        internal void MultiplicationGame(string message)
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

                Console.WriteLine($"{i + 1}. example: {firstNumber} * {secondNumber}");
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

            Helpers.AddToHistory(score, "Multiplication");
            Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
            Console.ReadKey();
        }

        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                Console.WriteLine($"{i + 1}. example: {divisionNumbers[0]} / {divisionNumbers[1]}");
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

            Helpers.AddToHistory(score, "Division");
            Console.WriteLine($"Your final score is: {score}\nPress any key to go back to main menu.\n");
            Console.ReadKey();
        }

        

    }
}
