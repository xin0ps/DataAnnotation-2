using Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts
{
    public interface IS_cartRepository: IGenericRepository<S_Cart>
    {
        ICollection<S_Cart>? GetAllTakesBook();
    }
}
