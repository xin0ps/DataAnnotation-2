using Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Concretes
{
    public class Book:BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? PageCount { get; set; }

        // Foreign Key
        public int? CategoryId { get; set; }


        //Navigation Property

        public virtual ICollection<S_Cart> S_Carts { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; } 

        public virtual ICollection<Author> Authors { get; set; }
        public virtual Category Category { get; set; }

    }
}
