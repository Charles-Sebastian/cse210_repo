using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;

        string gradeLetter;

        Console.Write("What is your grade percentage? ");
        string gradePercentageString = Console.ReadLine();
        int gradePercentageInt = int.Parse(gradePercentageString);

        if (gradePercentageInt >= a)
        {
            gradeLetter = "A";
        }
        else if (gradePercentageInt >= b)
        {
            gradeLetter = "B";
        }
        else if (gradePercentageInt >= c)
        {
            gradeLetter = "C";
        }
        else if (gradePercentageInt >= d)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        if (gradeLetter == "A" || gradeLetter == "F")
        {
            Console.WriteLine($"Your grade is an {gradeLetter}");
        }
        else
        {
            Console.WriteLine($"Your grade is a {gradeLetter}");
        }

        if (gradePercentageInt < c)
        {
            Console.WriteLine("Better luck next time!");
        }
        else
        {
            Console.WriteLine("Great Job!!!");
        }
    }
}