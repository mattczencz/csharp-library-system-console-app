using LibraryPlatform;

bool running = true;
Library library = new Library();

Console.WriteLine("Welcome to your virtual library!");

do
{
    Console.WriteLine("Please enter the number of the action you would like to do.");
    Console.WriteLine("1. Add Book");
    Console.WriteLine("2. Remove Book");
    Console.WriteLine("3. View Books");
    Console.WriteLine("4. Exit");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            break;
        case "2":
            break;
        case "3":
            library.DisplayBooks();
            break;
        case "4":
            Console.WriteLine("Exiting application.");
            running = false;
            break;
        default:
            Console.WriteLine("Invalid selection.");
            break;
    }
} while (running);


#region Program Actions

void AddAction()
{
    
}

void RemoveAction()
{
    
}

#endregion