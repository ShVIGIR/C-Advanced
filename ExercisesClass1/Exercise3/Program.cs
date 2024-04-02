
// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Task 3");
#region Task 3
//3.Create a console application that plays rock - paper - scissors 🔹
//* There should be a menu with three options:
//  *Play
//    1.The user picks rock paper or scissors option
//    2. The application picks rock paper scissors on random
//    3. The user pick and the application pick are shown on the screen
//    4. The application shows the winner
//    5. The application saves 1 score to the user or the computer in the background
//    6. When the user hits enter it returns to the main menu 
//  * Stats
//    1. It shows how many wins the user and how many wins the computer has
//    2. It shows percentage of the wins and loses of the user
//    3. When the user hits enter it returns to the main menu
//  * Exit
//    1. It closes the application
#endregion
#region Task 3 - Code

List<string> listOfResults = new List<string>();
string[] array = { "scissors", "rock", "paper" };
List<int> player = new List<int>();
List<int> app = new List<int>();
//int[] arrayPlayer = { };
//int[] appPlayer = { };

//Console.WriteLine("Let's play a game!");
Console.WriteLine("MENU");
 bool isTrue = true;
while (true)
{
    Console.WriteLine("PLAY - STATS - EXIT (Choose) ");
    string input = Console.ReadLine().ToLower();
    if (input != "PLAY".ToLower() && input != "STATS".ToLower() && input != "EXIT".ToLower())
    {
        Console.WriteLine("Enter valid choice!");
        continue;
    }
    else
    {
        if (input == "EXIT".ToLower())
        {

            break;
        }
        else if (input == "STATS".ToLower())
        {
            int resultFinalPlayer = player.Sum();
            int resultFinalApp = app.Sum();
            Console.WriteLine($"You have {resultFinalPlayer} wins, app has {resultFinalApp} wins.");

        }
        else if (input == "PLAY".ToLower())
        {
            while (isTrue)
            {
                Console.WriteLine("ROCK - PAPER - SCISSORS (Choose)");
                string inputChoose = Console.ReadLine().ToLower();
                if (string.IsNullOrEmpty(inputChoose))
                {
                    break;
                }

                if (inputChoose != "ROCK".ToLower() && inputChoose != "PAPER".ToLower() && inputChoose != "SCISSORS".ToLower())
                {
                    //listOfResults.Add(inputChoose);
                    Console.WriteLine("Enter valid input!");
                    continue;
                }

                else
                {
                    Random random = new Random();
                    int choiceIndexApp = random.Next(array.Length);
                    string choiceApp = array[choiceIndexApp];
                    Console.WriteLine(choiceApp);

                    if (inputChoose == "ROCK".ToLower() && choiceApp == "SCISSORS".ToLower())
                    {
                        Console.WriteLine("You won. The rock is winner.");
                        player.Add(1);
                    }
                    else if (inputChoose == "SCISSORS".ToLower() && choiceApp == "PAPER".ToLower())
                    {
                        Console.WriteLine("You won. The scissors are winner.");
                        player.Add(1);
                    }
                    else if (inputChoose == "PAPER".ToLower() && choiceApp == "ROCK".ToLower())
                    {
                        Console.WriteLine("You won. The paper is winner.");
                        player.Add(1);
                    }
                    else if (inputChoose == choiceApp)
                    {
                        Console.WriteLine("One more try! you are even.");
                        continue;
                    }
                   
                    else
                    {
                        Console.WriteLine("Sorry you lost!");
                        app.Add(1);
                    }
                }     
            }
        }
    }
}




#endregion

