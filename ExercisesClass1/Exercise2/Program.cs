// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Exercise 2");
#region Task 2
//## 2. Create a console application that checks if a day is a working day 🔹
//*The app should request for a user to enter a date as an input or multiple inputs
//* The app should then open and see if the day is a working day
//* It should show the user a message whether the date they entered is working or not
//  * Weekends are not working
//  * 1 January, 7 January, 20 April, 1 May, 25 May, 3 August, 8 September, 12 October, 23 October and 8 December are not working days as well
//* It should ask the user if they want to check another date
//  * Yes - the app runs again
// * No - the app closes
#endregion
#region Task 2 - Code

List<DateTime> holidays = new List<DateTime>()
{
    new DateTime(2024, 1, 1),
    new DateTime(2024, 4, 20),
    new DateTime(2024, 5, 1),
    new DateTime(2024, 5, 25),
    new DateTime(2024, 8, 3),
    new DateTime(2024, 9, 8),
    new DateTime(2024, 10, 12),
    new DateTime(2024, 10, 23),
    new DateTime(2024, 12, 8)
};
bool goOn = true;
Console.WriteLine("Enter date to check:");
while (goOn)
{
    string input = Console.ReadLine();
    bool isParsed = DateTime.TryParseExact(input, new[] { "d.M.yyyy", "d.M", "d.M.yy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTimeInput); //ova da go razgledam podobro
    if (isParsed)
    {
        bool festive = holidays.Any(holiday => holiday.Equals(dateTimeInput));
        bool weekend = dateTimeInput.DayOfWeek == DayOfWeek.Saturday || dateTimeInput.DayOfWeek == DayOfWeek.Sunday;


        if (festive)
        {
            Console.WriteLine($"{dateTimeInput} It is holiday.");
        }
        else if (weekend)
        {
            Console.WriteLine($"{dateTimeInput} Rest day! it is weekend.");
        }
        else
        {
            Console.WriteLine($"{dateTimeInput} Work day!");
        }
        while (true)
        {
            Console.WriteLine("Do you want to enter another date? (YES/NO)");
            string inputChoice = Console.ReadLine().ToLower();
            if (inputChoice != "YES".ToLower() && inputChoice != "NO".ToLower())
            {
                Console.WriteLine("Please enter valid choice.");
                continue;
            }
            else
            {
                if (inputChoice == "NO".ToLower())
                {
                    goOn = false;
                    break;
                }

                Console.WriteLine("Enter date: ");
                break; ;
            }
            continue;
        }
    }
    else
    {
        Console.WriteLine("Enter valid date.");
        continue;
    }
}

#endregion