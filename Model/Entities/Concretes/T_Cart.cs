using Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Concretes
{
    public class T_Cart:BaseEntity
    {
        public DateTime? DateIn {  get; set; }

        public DateTime DateOut { get; set; }


        //navigation property
        public int TeacherId { get; set; }
        public int BookId { get; set; }
        public Teacher Teacher { get; set; }


        public Book Book { get; set; }
    }
}
