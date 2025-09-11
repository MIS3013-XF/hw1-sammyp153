// HW1b Grade

// Your Name: Sam Pickens
// Did you seek help ? If yes, specify the helper or web link here: Referenced Sum of 3 In Class Practice

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Exam1;
            double Exam2;
            double Exam3;
            double Homework;
            double Participation;

            double Overall;

            string FirstNameAsString;
            string LastNameAsString;
            string IDAsString;
            string Exam1AsString;
            string Exam2AsString;
            string Exam3AsString;
            string HomeworkAsString;
            string ParticipationAsString;

            const double Exam1Percent = 0.15;
            const double Exam2Percent = 0.25;
            const double Exam3Percent = 0.25;
            const double HomeworkPercent = 0.20;
            const double ParticipationPercent = .15;

            Console.WriteLine("What is your First Name?");
            FirstNameAsString = Console.ReadLine();
            Console.WriteLine("What is your Last Name?");
            LastNameAsString = Console.ReadLine();
            Console.WriteLine("What is your student ID number?");
            IDAsString = Console.ReadLine();
            Console.WriteLine("What is your Exam 1 grade?");
            Exam1AsString = Console.ReadLine();
            Console.WriteLine("What is your Exam 2 grade?");
            Exam2AsString = Console.ReadLine();
            Console.WriteLine("What is your Exam 3 grade?");
            Exam3AsString = Console.ReadLine();
            Console.WriteLine("What is your Homework overall grade?");
            HomeworkAsString = Console.ReadLine();
            Console.WriteLine("What is your Participation overall grade?");
            ParticipationAsString = Console.ReadLine();

            Exam1 = Convert.ToDouble(Exam1AsString);
            Exam2 = Convert.ToDouble(Exam2AsString);
            Exam3 = Convert.ToDouble(Exam3AsString);
            Homework = Convert.ToDouble(HomeworkAsString);
            Participation = Convert.ToDouble(ParticipationAsString);
             
            Overall = (Exam1 * Exam1Percent) + (Exam2 * Exam2Percent) + (Exam3 * Exam3Percent) 
                + (Homework * HomeworkPercent) + (Participation * ParticipationPercent);

            Console.WriteLine(FirstNameAsString + " " + LastNameAsString + " (" + IDAsString + 
                "), your overall grade is " + Overall.ToString("N2") + "%");


        }
    }
}
