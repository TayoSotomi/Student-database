
using System.Reflection.Metadata;

bool ToContinue = true;

while (ToContinue)
{

    string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };
    string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };
    string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };

    // bool userEntry = false;
    // while (userEntry)
    bool ListOfStudents = true;
    while (ListOfStudents == true)
    {
        Console.WriteLine("Would you like to see a List of all students? (y/n) ");
        string list = Console.ReadLine().Trim().ToLower();
        if (list == "y")
        {
            foreach (string n in names)
            {
                ListOfStudents = true;   
                Console.WriteLine(n);
                
            }
        }
        else
        {
            ListOfStudents = false;
            
        }
        break;
    }
    int UserInput = -1;
    while (UserInput <= 0 || UserInput > names.Length)//Continue until number is valid
    {
        Console.Write($"Please ask for student name by number 0-{names.Length}:  ");

        UserInput = int.Parse(Console.ReadLine());
    }           
        UserInput--;//set input to 0 based index
        Console.WriteLine();
    //Printing Name
        Console.WriteLine("Name " + (UserInput + 1) + " is " + names[UserInput]);
    //Get category
        Console.Write("  What would you like to know? Enter \"Hometown\"  or \"Favorite Food\" : ");
        string Cat = Console.ReadLine().Trim().ToLower();

        if (Cat == "hometown" || Cat == "town")15
        {
            Console.WriteLine(names[UserInput] + " is from " + towns[UserInput]);
        }
        else if (Cat == "favorite food" || Cat == "food")
        {
            Console.WriteLine(names[UserInput] + " favorite food is " + foods[UserInput]);
        }
        else
        {
            Console.WriteLine("That category does not exist. Please try again");
            Console.WriteLine();
        }

    
    Console.Write("Would you like to learn about another student? \"y\" or \"n\" :  ");
    string userResponse = Console.ReadLine().Trim().ToLower();

    if (userResponse == "y")
    {
        ToContinue = true;
    }
    else if (userResponse == "n")
    {
        ToContinue = false;
        Console.WriteLine("Thanks!");

    }
    else
    {
        ToContinue = false;
        Console.WriteLine("Thanks!");

    }
}



/*
static int Userinput(int value)
{
    while( value <1 || value > 17)
    {
        return true;
    }
    return value;

}

*/


