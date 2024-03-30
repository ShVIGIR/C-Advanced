

using Class02.Task1.Entities.Interfaces;
using Class02.Task1.Entities.Models.BaseModel;
using System.Security.Cryptography.X509Certificates;

namespace Class02.Task1.Entities.Models
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; }

        public Teacher(int id, string name, string userName, List<string> subjects) : base(id, name, userName)
        {
            Subjects = subjects;
        }
        public void PrintSubjects()
        {  
            Console.WriteLine("Subjects: " + string.Join(", ", Subjects));
        }
        public override string PrintUser()
        {
            return $"Teacher: {PrintInfo()}, teaches: {Subjects.Count} subjects.";
        }
    }
}
