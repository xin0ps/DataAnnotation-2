using Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        ICollection<Student>? GetAll(Expression<Func<Student, bool>> expression);
    }
}
