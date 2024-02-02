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
    internal class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public ICollection<Student>? GetAll(Expression<Func<Student, bool>> expression)
        {
            return _context?.Students.Where(expression).ToList();
        }
    }
}
