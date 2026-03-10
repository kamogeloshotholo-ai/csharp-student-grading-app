using System;

string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = { 90, 95, 87, 88, 96, 96 };

Console.WriteLine("Student\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    int[] studentScores;

    if (name == "Sophia")
        studentScores = sophiaScores;
    else if (name == "Andrew")
        studentScores = andrewScores;
    else if (name == "Emma")
        studentScores = emmaScores;
    else
        studentScores = loganScores;

    int examAssignments = 5;

    int sumExamScores = 0;
    int sumExtraCreditScores = 0;

    for (int i = 0; i < studentScores.Length; i++)
    {
        if (i < examAssignments)
        {
            sumExamScores += studentScores[i];
        }
        else
        {
            sumExtraCreditScores += studentScores[i];
        }
    }

    decimal examScore = (decimal)sumExamScores / examAssignments;
    decimal extraCreditPoints = (decimal)sumExtraCreditScores / 10;

    decimal overallScore = examScore + extraCreditPoints;

    string letterGrade;

    if (overallScore >= 97)
        letterGrade = "A+";
    else if (overallScore >= 93)
        letterGrade = "A";
    else if (overallScore >= 90)
        letterGrade = "A-";
    else if (overallScore >= 87)
        letterGrade = "B+";
    else if (overallScore >= 83)
        letterGrade = "B";
    else
        letterGrade = "B-";

    Console.WriteLine($"{name}\t{examScore:F1}\t\t{overallScore:F2} {letterGrade}\t{sumExtraCreditScores} ({extraCreditPoints:F2} pts)");
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();