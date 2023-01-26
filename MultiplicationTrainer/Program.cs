namespace MultiplicationTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var min = GetValue("Минимальное");
            var max = GetValue("Максимальное", min);
            var exerciseList = ExerciseBlock.CreateExerciseList(min, max);
            while (true)
            {
                ExerciseBlock.Refresh();
                var count = exerciseList.Count;
                foreach (var exercise in exerciseList)
                {
                    Console.WriteLine($"Осталось тестов: {count}\n");
                    Console.Write(exercise);
                    int.TryParse(Console.ReadLine(), out int answer);
                    if (answer == exercise.RigthAnswer)
                        ExerciseBlock.DoRightAnswer();
                    else
                        ExerciseBlock.DoWrongAnswer(exercise.RigthAnswer);
                    count--;
                    Console.Clear();
                }
                ExerciseBlock.ShowResult();
            }
        }

        static int GetValue(string valueType, int min = 1)
        {
            while (true)
            {
                Console.Write($"{valueType} число: ");
                int.TryParse(Console.ReadLine(), out int value);
                Console.Clear();
                if (value > min && value < 10)
                    return value;
                Console.WriteLine($"Введите число, которое больше {min} и меньше 10\n");
            }
        }
    }
}