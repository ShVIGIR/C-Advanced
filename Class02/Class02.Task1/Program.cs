using Class02.Task1.Entities.Models;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Abstract Classes and Interfaces - Task 1");
Console.ResetColor();
Console.ReadLine();

#region Creating istances
Student sara = new Student(1, "Sara Angelovska", "angelovska_s", new List<int> { 6, 6, 7, 8, 9 });
Student spase = new Student(2, "Spase Gjorgjevski", "spase.gj", new List<int> { 7, 8, 7, 9, 6 });
Teacher verka = new Teacher(101, "Verka Arminoska", "arminoska", new List<string> { "Mathematic", "Literature", "Programming" });
Teacher emil = new Teacher(102, "Emil Kaliu", "kaliu", new List<string> { "Physics", "Chemistry" });
#endregion

#region Implementation
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(sara.PrintUser());
sara.PrintGrades();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(spase.PrintUser());
spase.PrintGrades();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(verka.PrintUser());
verka.PrintSubjects();
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(emil.PrintUser());
emil.PrintSubjects();
Console.ResetColor();
#endregion

