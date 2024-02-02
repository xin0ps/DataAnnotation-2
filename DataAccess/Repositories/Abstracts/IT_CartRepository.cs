using Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts
{
    public interface IT_CartRepository : IGenericRepository<T_Cart>
    {

        ICollection<T_Cart>? GetAllTakenBook(Expression<Func<T_Cart, bool>> expression);
    }
}
