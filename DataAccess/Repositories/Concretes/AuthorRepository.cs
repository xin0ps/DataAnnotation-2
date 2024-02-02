using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace DataAccess.Repositories.Concretes
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public ICollection<Author>? GetAll(Expression<Func<Author, bool>> expression)
        {
           return _context?.Authors.Where(expression).ToList();
        }
    }
}
