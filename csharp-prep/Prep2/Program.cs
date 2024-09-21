using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        string grade;

        if (percentage >= 90) {
            grade = "A";

        }
        else if(percentage >= 80){
            grade = "B";

        }
        else if(percentage >= 70){
            grade = "C";
        }
        else if (percentage >= 60){
            grade = "D";
        }
        else{
            grade = "F";
        }

        if (percentage % 10 >= 7 && grade != "A" && grade != "F") {
            grade += "+";
        }
        else if (percentage % 10 < 3 && grade != "F") {
            grade += "-";
        }

        Console.WriteLine($"Your grade is {grade}");

    }
}