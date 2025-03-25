using LibraryPlatform;

bool running = true;
int checkedOutCount = 0;
Library library = new Library();

Console.WriteLine("Welcome to your virtual library!");

do
{
    Console.WriteLine("Please enter the number of the action you would like to do.");
    Console.WriteLine("1. Add Book");
    Console.WriteLine("2. Remove Book");
    Console.WriteLine("3. View Books");
    Console.WriteLine("4. Search Books");
    Console.WriteLine("5. Check-out Book");
    Console.WriteLine("6. Check-in Book");
    Console.WriteLine("7. Exit");

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
            SearchAction();
            break;
        case "5":
            CheckoutAction();
            break;
        case "6":
            CheckinAction();
            break;
        case "7":
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

void SearchAction()
{
    string? title = null;
    while (title == null)
    {
        Console.WriteLine("Enter the name of the book you are looking for:");
        title = Console.ReadLine();
    }

    if (!library.IsBookInLibrary(title))
    {
        Console.WriteLine($"{title} is not in the library.");
        return;
    }
    
    Console.WriteLine($"{title} was found in the library.");
}

void CheckinAction()
{
    if (checkedOutCount == 0)
    {
        Console.WriteLine("You don't have any books to check-in.");
        return;
    }

    string? title = null;
    while (title == null)
    {
        Console.WriteLine("Enter the name of the book you would like to check-in:");
        title = Console.ReadLine();
    }

    if (library.CheckinBook(title))
    {
        checkedOutCount--;
    }
}

void CheckoutAction()
{
    if (checkedOutCount == 3)
    {
        Console.WriteLine("You cannot check-out any more books.");
        return;
    }

    string? title = null;
    while (title == null)
    {
        Console.WriteLine("Enter the name of the book you would like to check-out:");
        title = Console.ReadLine();
    }

    if (library.CheckoutBook(title))
    {
        checkedOutCount++;
    }
}

#endregion