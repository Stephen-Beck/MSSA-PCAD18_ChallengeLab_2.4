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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLab_2._4
{
    public class Student
    {
        public static int numberOfStudents = 0;

        public int ID { get; set; }
        public string Name { get; set; }
        public int GradePhysics{ get; set; }
        public int GradeChemistry { get; set; }
        public int GradeComputerApplication { get; set; }

        public Student(string name)
        {
            ID = ++numberOfStudents;
            Name = name;
        }

        public void DisplayGrades()
        {
            int gradesTotal = GradePhysics + GradeChemistry + GradeComputerApplication;
            float gradesPercentage = gradesTotal / 3;
            Console.WriteLine(@$"
Student ID: {ID}
Student Name: {Name}
Physics Grade: {GradePhysics}
Chemistry Grade: {GradeChemistry}
Comp.App. Grade: {GradeComputerApplication}
Grade Total: {gradesTotal}
Percentage: {(gradesPercentage).ToString("N2")}
Division: {DetermineDivision(gradesPercentage)}");
        }
        
        private string DetermineDivision(float gradesPercentage)
        {
            switch(gradesPercentage)
            {
                case >= 90:
                    return "First";
                case >= 80:
                    return "Second";
                case >= 70:
                    return "Third";
                case >= 60:
                    return "Fourth";
                default:
                    return "Fail";
            }
        }
    }
}
