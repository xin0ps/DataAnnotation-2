using Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        ICollection<Category>? GetAll(Expression<Func<Category, bool>> expression);
    }
}
