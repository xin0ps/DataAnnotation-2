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
    internal class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public ICollection<Category>? GetAll(Expression<Func<Category, bool>> expression)
        {
            return _context?.Categories.Where(expression).ToList();
        }
    }
}
