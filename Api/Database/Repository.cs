public class Repository
{
    List<Author> Authors = new List<Author>();
    List<Book> Books = new List<Book>();

    public Task<List<Book>> GetBooksAsync()
    {
        return Task.FromResult(Books);
    }

    public Task<Author?> GetAuthor(Guid authorId)
    {
        return Task.FromResult( Authors.FirstOrDefault(a => a.Id == authorId));
    }

    public Task AddAuthor(Author author)
    {
        Authors.Add(author);
        return Task.CompletedTask;
    }

    public Task AddBook(Book book)
    {
        Books.Add(book);
        return Task.CompletedTask;
    }
}