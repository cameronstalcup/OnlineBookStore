using System.Collections.Generic;

namespace OnlineBookStore.Models
{
    public class Genre
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}