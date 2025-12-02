using System;

class Student
{
    public string Name { get; set; }

    private int average;

    public Student(string studentName, int studentAverage)
    {
        Name = studentName;
        Average = studentAverage; 
    }

    public int Average
    {
        get => average;
        set
        {
            if (value > 0 && value <= 100)
            {
                average = value;
            }
        }
    }

    public string LetterGrade
    {
        get
        {
            if (average >= 90) return "A";
            if (average >= 80) return "B";
            if (average >= 70) return "C";
            if (average >= 60) return "D";
            return "F";
        }
    }
}
