﻿using Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Concretes
{
    public class BookAuthor : BaseEntity
    {


        public int BookId { get; set; }

        public int AuthorId { get; set; }
        public Book Book { get; set; } 
        public Author Author { get; set; } 


    }
}
