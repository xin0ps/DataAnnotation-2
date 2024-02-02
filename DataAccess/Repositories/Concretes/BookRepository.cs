using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concretes
{
    internal class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public ICollection<Book>? GetAllWithCategory()
        {
            return _context?.Books.Include(x => x.Category).ToList();
        }
    }
}
