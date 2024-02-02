using DataAccess.Repositories.Abstracts;
using Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concretes
{
    internal class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public ICollection<Teacher>? GetAll(Expression<Func<Teacher, bool>> expression)
        {
            return _context?.Teachers.Where(expression).ToList();
        }
    }
}
