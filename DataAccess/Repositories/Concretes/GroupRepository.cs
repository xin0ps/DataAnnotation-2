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
    internal class GroupRepository : GenericRepository<Group>, IGroupRepository
    {
        public ICollection<Group>? GetAll(Expression<Func<Group, bool>> expression)
        {
            return _context?.Groups.Where(expression).ToList();
        }
    }
}
