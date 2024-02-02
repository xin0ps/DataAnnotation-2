using DataAccess.Contexts;
using DataAccess.Repositories.Abstracts;
using Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concretes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
    {


        internal readonly LibraryContext? _context;

        public GenericRepository()
        {
            _context = new LibraryContext();
        }


        public void Add(T entity)
        {

            if (entity is null) throw new Exception($"{entity!.GetType().FullName} is null");
            _context?.Set<T>().Add(entity);
        }

        public ICollection<T>? GetAll()
        {
            return _context?.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
            if (id <= 0) throw new Exception("Id is not valid");
            var entity = _context?.Set<T>().FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public void Remove(T entity)
        {
            if (entity is null) throw new Exception("entity is NUll");
            _context?.Set<T>().Remove(entity);
        }

        public void Remove(int id)
        {
            if (id <= 0) throw new Exception("Id is not valid");
            var entity = _context?.Set<T>().FirstOrDefault(x => x.Id == id);
            if (entity is null) throw new Exception("entity is NUll");
            _context?.Set<T>().Remove(entity);
        }

        public void SaveChanges()
        {
            _context?.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity is null) throw new Exception("entity is NUll");
            _context?.Set<T>().Update(entity);
        }
    }
}
