using System;

class StudentTest
{
    static void Main()
    {
        var student1 = new Student("Jane Green", 93);
        var student2 = new Student("John Blue", 72);

        Console.WriteLine($"{student1.Name}'s letter grade equivalent of {student1.Average} is {student1.LetterGrade}");
        Console.WriteLine($"{student2.Name}'s letter grade equivalent of {student2.Average} is {student2.LetterGrade}");
    }
}
