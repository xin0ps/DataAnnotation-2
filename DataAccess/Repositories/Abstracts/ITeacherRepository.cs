using Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts
{
    public interface ITeacherRepository : IGenericRepository<Teacher>
    {
        ICollection<Teacher>? GetAll(Expression<Func<Teacher, bool>> expression);

    }
}
