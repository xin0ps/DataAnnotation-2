using Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Concretes
{
    public class Author:BaseEntity
    {
        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? About { get; set; }


        // Navigation Property

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
