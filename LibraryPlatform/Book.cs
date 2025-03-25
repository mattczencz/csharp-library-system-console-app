namespace LibraryPlatform;

public class Book(string title)
{
    public string Title { get; } = title;
    public bool CheckedOut { get; set; } = false;
}