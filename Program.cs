/*
Write a C# Sharp program to read:
    Student ID number
    Student Name
    Grades of three subjects
Calculate:
    Sum of grades
    Percentage of maximum grade
    Division
        >= 90% First
        >= 80% Second
        >= 70% Third
        >= 60% Fourth
        <  60% Fail
(Use a class to represent the student)

Test Data :
    Input the Roll Number of the student :784
    Input the Name of the Student :James
    Input the marks of Physics, Chemistry and Computer Application : 70 80 90

Expected Output :
    Roll No : 784
    Name of Student : James
    Marks in Physics : 70
    Marks in Chemistry : 80
    Marks in Computer Application : 90
    Total Marks = 240
    Percentage = 80.00
    Division = First
*/

using System.Collections.Generic;

namespace ChallengeLab_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List < Student > students = new List<Student>();
            
            Console.Write("Please enter the name of your student: ");
            string userInput = Console.ReadLine();
            Student student = new(userInput);

            student.GradePhysics = UserInput(student, "Physics");
            student.GradeChemistry = UserInput(student, "Chemistry");
            student.GradeComputerApplication = UserInput(student, "Computer Application");

            student.DisplayGrades();
            
        }

        static int UserInput(Student student, string subject)
        {
            Console.Write($"What is {student.Name}'s grade in {subject}? ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine().Trim(), out int grade))
                {
                    return grade;
                }
                else Console.Write("Input a valid grade number: ");
            }
        }
    }
}
