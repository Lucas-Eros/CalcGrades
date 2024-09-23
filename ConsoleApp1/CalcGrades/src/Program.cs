using CalcGradies.Models;
using CalcGradies.Services;

StudentService studentService = new StudentService();

Student student1 = studentService.CreateStudent(1, "Lucas", [8, 8, 8, 8], [10, 10, 10, 10]);

studentService.GetStudent(student1);

Console.WriteLine("\n Adicionar novo aluno:");
Console.Write("Digite o ID do aluno: ");
int id = int.Parse(Console.ReadLine()!);

Console.Write("Digite o nome do aluno: ");
string name = Console.ReadLine()!;

List<double> grades = new List<double>();
List<double> weights = new List<double>();
Console.Write("Quantas notas o aluno tem? ");
int countGrades = int.Parse(Console.ReadLine()!);

for (int i = 0; i < countGrades; i++)
{
    Console.Write($"Digite a nota {i + 1}: ");
    double grade = double.Parse(Console.ReadLine()!);
    grades.Add(grade);

    Console.Write($"Digite o peso para a n2ota {i + 1}: ");
    double weight = double.Parse(Console.ReadLine()!);
    weights.Add(weight);
}

Student newStudent = studentService.CreateStudent(id, name, grades, weights);
studentService.GetStudent(newStudent);
