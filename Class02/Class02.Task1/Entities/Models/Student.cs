
using Class02.Task1.Entities.Interfaces;
using Class02.Task1.Entities.Models.BaseModel;
using System.Diagnostics.CodeAnalysis;

namespace Class02.Task1.Entities.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }
        public Student(int id, string name, string userName, List<int>grades) : base(id, name, userName)
        {
            Grades = grades;
        }

        public void PrintGrades()
        {     
                Console.WriteLine("Grades: " + string.Join(", ", Grades)); 
        }
       

        public override string PrintUser()
        {
            double average = Grades.Average();
            return $"Student {PrintInfo()}. Average grade: {average} ";
        }
    }
}
