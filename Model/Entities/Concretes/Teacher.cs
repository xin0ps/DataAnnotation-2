using Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Concretes
{
    public class Teacher:BaseEntity
    {

        public string Name { get; set; }

        public string Surname { get; set; }



        //Navigation property

        public virtual ICollection<T_Cart> T_Carts { get; set; }
    }
}
