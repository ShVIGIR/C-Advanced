// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Exercise 1");
#region Task 1
//## 1. Create a console application that detect provided names in a provided text 🔹
//*The application should ask for names to be entered until the user enteres x
//* After that the application should ask for a text
//* When that is done the application should show how many times that name was included in the text ignoring upper/lower case
#endregion
#region Task 1 - Code



List<string> list = new List<string>();
bool isGoing = true;
while (isGoing)
{
    Console.WriteLine("Enter a name: ");

    string input = Console.ReadLine();
    list.Add(input);


    Console.WriteLine("Do you want to enter another name: (Y/X)");
    input = Console.ReadLine();
    if (input != "Y".ToLower() && input != "X".ToLower())
    {
        Console.WriteLine("Enter valid input.");
        continue;
    }
    if (input == "X".ToLower())
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        List<string> words = text.Split(' ').ToList();
        foreach (string w in list)
        {
            int count = words.Where(w => w.Equals(w, StringComparison.OrdinalIgnoreCase)).Count();
            Console.WriteLine($"{w} {count}");
        }
    }
    else
    {
        continue;
    }
    break;
}
Console.ReadLine();
#endregion