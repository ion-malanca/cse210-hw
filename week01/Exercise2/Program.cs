using System;

class Program
{
    static void Main(string[] args) {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        String letterGrade;
        String sign = "";

        if (grade >= 90) {
            letterGrade = "A";
        }
        else if (grade >= 80) {
            letterGrade = "B";
        }
        else if (grade >= 70) {
            letterGrade = "C";
        }
        else if (grade >= 60) {
            letterGrade = "D";
        }
        else {
            letterGrade = "F";
        }

        if (grade % 10 >= 7 && grade < 90 && grade > 60)
        {
            sign = "+";
        }
        else if (grade % 10 <= 3 && grade > 60)
        {
            sign = "-";
        }

        Console.WriteLine("Your grade is " + letterGrade + sign);

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You've passed this class");
        } else
        {
            Console.WriteLine("Unfortunately you have not passed, but you will next time!");
        }
    }
}