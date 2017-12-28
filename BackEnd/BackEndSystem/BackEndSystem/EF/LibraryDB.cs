using System;

public class BookList
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int authorId { get; set; }
    public int GenreId { get; set; }
    public string DatePublished { get; set; }
    public int MediaTypeId { get; set; }
}
public class Genre
{
    public int Id { get; set; }
    public string title { get; set; }
}
public class Author
{
    public int Id { get; set; }
    public string name { get; set; }
}
public class MediaType
{
    public int Id { get; set; }
    public string name { get; set; }
}