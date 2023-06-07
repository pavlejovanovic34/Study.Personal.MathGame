namespace MathGameLibrary.Models
{
    internal class Game
    {
        internal int Score { get; set; }

        internal DateTime Date { get; set; }

        internal GameType Type { get; set; }

        internal string Difficulty { get; set; }

        internal TimeSpan TimeElapesd { get; set; }

        internal int NumOfQuestions { get; set; }

    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        RandomGame
    }
}
