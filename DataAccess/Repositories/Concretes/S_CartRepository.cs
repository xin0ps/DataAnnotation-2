
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
    internal class S_CartRepository : GenericRepository<S_Cart>, IS_cartRepository
    {
        public ICollection<S_Cart>? GetAllTakesBook()
        {
            return _context.S_Carts.Where(s=>s.DateIn ==null).ToList();
        }
    }
}
