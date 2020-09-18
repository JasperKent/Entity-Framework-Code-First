using System.Collections.Generic;

namespace BookLibrary
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
