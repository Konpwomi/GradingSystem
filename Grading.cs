using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    public class Grading
    {
        public static void GradeCalculator (int score)
        {
            if (score < 0)
            {
                Console.WriteLine("Error: Score is lower than zero (" + score + ")");
            }
            else if (score > 100) {
                Console.WriteLine("Error: Score is over hundred (" + score + ")");
            }
            else
            {
                if (score >= 80 && score < 100)
                {
                    Console.WriteLine("Grade: A (" + score + ")");
                }
                else
                {
                    if (score >= 70 && score < 80)
                    {
                        Console.WriteLine("Grade: B (" + score + ")");
                    }
                    else
                    {
                        if (score >= 60 && score < 70)
                        {
                            Console.WriteLine("Grade: C (" + score + ")");
                        }
                        else
                        {
                            if (score >= 50 && score < 60)
                            {
                                Console.WriteLine("Grade: D (" + score + ")");
                            }
                            else
                            {
                                Console.WriteLine("Grade: F (" + score + ")");
                            }
                        }
                    }
                }
            }
        }
    }
}
