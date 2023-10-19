using System.Text.RegularExpressions;

namespace GradingSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, @"[^0-9abc]"))
            {
                Console.WriteLine("Please type only numbers, Try again.");
            }
            else
            {
                int score = Convert.ToInt32(input);
                Grading.GradeCalculator(score);
            }
        }
    }
}