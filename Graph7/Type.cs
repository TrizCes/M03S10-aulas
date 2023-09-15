
namespace Graph7
{
  public class Book
  {
    public string Title { get; set; }
    public Author Author { get; set; }
  }

  public class Author
  {
    public String Name { get; set; }

        public Author(string name = "") { Name = name; }

        public static implicit operator Author(string v)
        {
            throw new NotImplementedException();
        }
    }
}