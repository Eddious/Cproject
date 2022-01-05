using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int score;
            int ID;

            Console.WriteLine("Enter student id and exam score");

            ID = int.Parse(Console.ReadLine());
            score = int.Parse(Console.ReadLine());

            if (score >= 90)
                Console.WriteLine("A");
            else
                if ((score >= 80) && (score <= 89))
                    Console.WriteLine("B");
                else
                    if ((score >= 70) && (score <= 79))
                        Console.WriteLine("C");
                    else
                        if ((score >= 60) && (score <= 69))
                            Console.WriteLine("D");
                        else
                            if (score <= 59)
                                Console.WriteLine("E");
            
            Console.ReadKey();
        }
    }
}
