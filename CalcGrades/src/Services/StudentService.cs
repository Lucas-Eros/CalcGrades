using CalcGradies.Models;

namespace CalcGradies.Services;

public class StudentService
{
    public double GetAverageGrade(Student student)
    {
        return student.GetAverageGrade();
    }

    public void GetStudent(Student student)
    {
        Console.WriteLine(student);
    }

    public Student CreateStudent(int id, string? name, List<double> grades, List<double> weights)
    {
        return new Student(id, name, grades, weights);
    }
    
}