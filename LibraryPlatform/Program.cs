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
            AddAction();
            break;
        case "2":
            RemoveAction();
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
    string? title = null;
    while (title == null)
    {
        Console.WriteLine("Enter a book title:");
        title = Console.ReadLine();
    }

    library.AddBook(title);
}

void RemoveAction()
{
    if (library.CountBooksInLibrary() == 0)
    {
        Console.WriteLine("Unable to perform action. There are no books in your library.");
        return;
    }

    string? title = null;
    while (title == null)
    {
        Console.WriteLine("Enter the title of the book you would like to remove:");
        title = Console.ReadLine();
    }
    
    library.RemoveBook(title);
}

#endregion