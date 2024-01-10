
public class Libruary : ILibrary
{
    List<Book> books = new List<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public Book DisplayBook(int id)
    {
        var book = books.FirstOrDefault(e => e.Id == id);
        return book;
    }
    public void UpdateBook(Book book,int id)
    {
        book = books.FirstOrDefault(p => p.Id == id);
        {
            book.Id = 5;
            book.Tittle = "Sino";
            book.Author = "Rumi";

        }
        

    }
    public void DeleteBook(int id)
    {
        var book = books.FirstOrDefault(e => e.Id == id);
        {
            books.Remove(book);
            System.Console.WriteLine("Book was deleting succesfully");
        }
        System.Console.WriteLine("Book not found");

    }
    public Book SearchByTitle(string tittle)
    {
        var book = books.FirstOrDefault(e => e.Tittle == tittle);
        {
            return book;
        }
    }
    public Book SearchByAuthor(string author)
    {
        var book = books.FirstOrDefault(e => e.Author == author);
         {
            return book;
         }
    }
}




