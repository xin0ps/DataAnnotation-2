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
    internal class T_CartRepository : GenericRepository<T_Cart>, IT_CartRepository
    {
   

        ICollection<T_Cart>? IT_CartRepository.GetAllTakenBook(Expression<Func<T_Cart, bool>> expression)
        {
            return _context?.T_Carts.Where(expression).ToList();
        }
    }
}
