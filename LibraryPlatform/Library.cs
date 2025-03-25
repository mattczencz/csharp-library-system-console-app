namespace LibraryPlatform;

public class Library
{
    public string[] Books { get; } = new string[5];

    public void AddBook(string name)
    {
        int freeSlot = Array.FindIndex(Books, s => string.IsNullOrEmpty(s));

        if (freeSlot < 0)
        {
            Console.WriteLine("Library is full. Please remove a book to add another.");
            return;
        }

        Books[freeSlot] = name;
    }

    public void RemoveBook(string name)
    {
        int bookIndex = Array.FindIndex(Books, s => s == name);

        if (bookIndex < 0)
        {
            Console.WriteLine("Could not find that book to remove.");
            return;
        }

        Books[bookIndex] = "";
    }

    public void DisplayBooks()
    {
        string[] booksWithTitle = Books.Where(s => !string.IsNullOrEmpty(s)).ToArray();

        if (booksWithTitle.Length > 0)
        {
            Console.WriteLine("================ Books in your library ================");
            foreach (var book in booksWithTitle)
            {
                Console.WriteLine(book);
            }
        }
        else
        {
            Console.WriteLine("You don't have any books in your library.");
        }
    }
}