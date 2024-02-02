using Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Concretes
{
    public class S_Cart:BaseEntity
    {

        public DateTime? DateIn { get; set; }

        public DateTime DateOut { get; set; }


        //navigation property
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public Student Student { get; set; }
        public Book Book { get; set; }
    }
}
