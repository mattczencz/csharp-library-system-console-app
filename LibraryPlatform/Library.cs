namespace LibraryPlatform;

public class Library
{
    public Book?[] Books { get; } = [ null, null, null, null, null ];

    public void AddBook(string name)
    {
        int freeSlot = Array.FindIndex(Books, book => book == null);

        if (freeSlot < 0)
        {
            Console.WriteLine("Library is full. Please remove a book to add another.");
            return;
        }

        Books[freeSlot] = new Book(name);
    }

    public void RemoveBook(string name)
    {
        int bookIndex = Array.FindIndex(Books, book => book?.Title == name);

        if (bookIndex < 0)
        {
            Console.WriteLine("Could not find that book to remove.");
            return;
        }

        Books[bookIndex] = null;
    }

    public void DisplayBooks()
    {
        Book?[] booksWithTitle = Books.Where(book => book != null).ToArray();

        if (booksWithTitle.Length > 0)
        {
            Console.WriteLine("================ Books in your library ================");
            foreach (var book in booksWithTitle)
            {
                Console.WriteLine(book.Title);
            }
        }
        else
        {
            Console.WriteLine("You don't have any books in your library.");
        }
    }

    public int CountBooksInLibrary()
    {
        return Books.Where(book => book != null).ToArray().Length;
    }

    public bool IsBookInLibrary(string name)
    {
        return Array.Find(Books, book => book?.Title == name) != null;
    }

    public bool CheckoutBook(string name)
    {
        Book? book = Array.Find(Books, book => book?.Title == name);

        if (book == null)
        {
            Console.WriteLine("Could not find that book to checkout.");
            return false;
        }

        if (book.CheckedOut)
        {
            Console.WriteLine("This book is already checked out.");
            return false;
        }

        book.CheckedOut = true;
        return true;
    }
    
    public bool CheckinBook(string name)
    {
        Book? book = Array.Find(Books, book => book?.Title == name);

        if (book == null)
        {
            Console.WriteLine("That book was never in the library.");
            return false;
        }

        if (!book.CheckedOut)
        {
            Console.WriteLine("This book is already checked in.");
            return false;
        }

        book.CheckedOut = false;
        return true;
    }
}