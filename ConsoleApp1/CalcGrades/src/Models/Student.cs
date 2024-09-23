namespace CalcGradies.Models;

public class Student
{
    private int Id { get; set; }
    private string? Name { get; set; }
    private List<double> Grades { get; set; }
    private List<double> Weights { get; set; }
    
    public Student(int id, string? name, List<double> grades, List<double> weights)
    {
        Id = id;
        Name = name;
        Grades = grades;
        Weights = weights;
    }
    
    public double GetAverageGrade()
    {
        double averageGradeSum = 0;
        double weightsSum = 0;
        
        if (Grades.Count == 0) 
        {
            return 0;
        }

        for (int i = 0; i < Grades.Count; i++)
        {
            averageGradeSum += Grades[i] * Weights[i];
            weightsSum += Weights[i];
        }
        
        return averageGradeSum / weightsSum;
    }
    
    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Name}, Média Ponderada: {GetAverageGrade()}";
    }
}