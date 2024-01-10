var book = new Book();
book.Id = 1;
book.Tittle = "Barotov";
book.Author = "Mustafo";

var book2 = new Book();
book2.Id = 2;
book2.Tittle = "Rudaki";
book2.Author = "Sherozi";

var booko = new List<Book>();

booko.Add(book);
booko.Add(book2);

foreach (var item in booko)
{
    System.Console.Write("Id - ");
    System.Console.WriteLine(item.Id);
    System.Console.Write("Tittle - ");
    System.Console.WriteLine(item.Tittle);
    System.Console.Write("Author - ");
    System.Console.WriteLine(item.Author);
}

var libruary = new Libruary();
libruary.AddBook(3,"uuu","aaa");
libruary.DeleteBook(1);
libruary.UpdateBook();
libruary.SearchByAuthor();
libruary.SearchByTitle();6



