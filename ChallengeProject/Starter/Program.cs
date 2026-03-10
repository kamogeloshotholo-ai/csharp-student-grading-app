using System;

int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = { 90, 95, 87, 88, 96, 96 };

string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

Console.Clear();
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

    int examScore = 0;
    int extraCreditScore = 0;
    int examAssignments = 5;

    decimal extraCreditPoints = 0;
    decimal overallScore = 0;
    string letterGrade = "";

    int sumExamScores = 0;
    int sumExtraCreditScores = 0;

    for (int i = 0; i < studentScores.Length; i++)
    {
        if (i < examAssignments)
            sumExamScores += studentScores[i];
        else
            sumExtraCreditScores += studentScores[i];
    }

    examScore = sumExamScores / examAssignments;

    extraCreditScore = sumExtraCreditScores;
    extraCreditPoints = (decimal)sumExtraCreditScores / 10;

    overallScore = examScore + extraCreditPoints;

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
    else if (overallScore >= 80)
        letterGrade = "B-";
    else if (overallScore >= 77)
        letterGrade = "C+";
    else if (overallScore >= 73)
        letterGrade = "C";
    else if (overallScore >= 70)
        letterGrade = "C-";
    else if (overallScore >= 67)
        letterGrade = "D+";
    else if (overallScore >= 63)
        letterGrade = "D";
    else if (overallScore >= 60)
        letterGrade = "D-";
    else
        letterGrade = "F";

    Console.WriteLine($"{name}\t{examScore}\t\t{overallScore:F2} {letterGrade}\t{extraCreditScore} ({extraCreditPoints:F2} pts)");
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();