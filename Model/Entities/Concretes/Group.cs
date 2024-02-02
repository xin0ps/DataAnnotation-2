using Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Concretes
{
    public class Group:BaseEntity
    {
        public string Name { get; set; }

        //navigation property

        public virtual ICollection<Student> Studens { get; set; }
    }
}
