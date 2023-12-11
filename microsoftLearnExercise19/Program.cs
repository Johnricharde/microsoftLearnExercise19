namespace microsoftLearnExercise19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] schedule = { 800, 1200, 1600, 2000 };


            DisplayAdjustedTimes(schedule, 6, -6);


            void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
            {
                int timeDifference = 0;

                if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
                    Console.WriteLine("Invalid GMT");
                else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
                    timeDifference = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                else
                    timeDifference = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

                for (int i = 0; i < times.Length; i++)
                {
                    int newTime = ((times[i] + timeDifference)) % 2400;
                    Console.WriteLine($"{times[i]} -> {newTime}");
                }
            }
        }
    }
}
