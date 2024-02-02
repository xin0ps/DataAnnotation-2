using Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts
{
    public interface IGroupRepository : IGenericRepository<Group>
    {
        ICollection<Group>? GetAll(Expression<Func<Group, bool>> expression);
    }
}
