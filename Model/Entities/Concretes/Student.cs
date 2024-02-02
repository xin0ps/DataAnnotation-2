using Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Concretes
{
    public class Student:BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int GroupId { get; set; }

        public virtual ICollection<S_Cart> S_Carts { get; set; }

        //Navigation property

        public Group Group { get; set; }
    }
}
