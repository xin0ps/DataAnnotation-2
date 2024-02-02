using Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        ICollection<Book>? GetAllWithCategory();
    }
}
