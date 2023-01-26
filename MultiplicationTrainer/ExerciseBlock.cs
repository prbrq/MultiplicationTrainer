using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTrainer
{
    static class ExerciseBlock
    {
        public static decimal RightAnswers { get; private set; }

        public static List<Exercise> ExerciseList = ExerciseList = new List<Exercise>();

        public static List<Exercise> CreateExerciseList(int min, int max)
        {
            for (var i = min; i <= max; i++)
                for (var j = min; j <= max; j++)
                    ExerciseList.Add(new Exercise(i, j));
            return ExerciseList;
        }

        public static void Refresh()
        {
            ExerciseList.Shuffle();
            RightAnswers = 0;
        }

        public static void ShowResult()
        {
            Console.Write($"Правильных ответов {Math.Round(RightAnswers / ExerciseList.Count * 100, 2)}%");
            CheckExit();
            Console.Clear();
        }

        public static void DoRightAnswer() => RightAnswers++;

        public static void DoWrongAnswer(int rigthAnswer)
        {
            Console.Write($"\nНеверно... Правильный ответ = {rigthAnswer}");
            CheckExit();
        }

        private static void CheckExit()
        {
            Console.Write(". Нажмите Esc для выхода, любую клавишу для продолжения.");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
                Environment.Exit(0);
        }
    }
}
