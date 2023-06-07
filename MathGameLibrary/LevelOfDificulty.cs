

namespace MathGameLibrary
{
    internal class LevelOfDificulty
    {
        internal static int[] Easy(int numOfQuestions)
        {
            Random random = new Random();
            int[] numbers = new int[numOfQuestions * 2];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1,10);
            }

           

            return numbers;
        }

        internal static int[] Medium(int numOfQuestions) 
        {
            Random random = new Random();
            int[] numbers = new int[numOfQuestions * 2];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(10, 100);
            }

            

            return numbers;
        }

        internal static int[] Hard(int numOfQuestions)
        {
            Random random = new Random();
            int[] numbers = new int[numOfQuestions * 2];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100, 1000);
            }

            

            return numbers;
        }

         
    }

    
}
