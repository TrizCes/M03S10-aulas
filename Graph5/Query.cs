using System.Diagnostics.Eventing.Reader;
using Graph5;

namespace Graph5
{
  public class Query
  {
    public Book GetBook() =>
        new Book
        {
            Title = "C# in depth.",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
  }
}