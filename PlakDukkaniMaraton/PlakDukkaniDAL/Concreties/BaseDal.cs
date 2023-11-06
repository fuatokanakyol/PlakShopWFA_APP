using PlakDukkaniDAL.Context;
using PlakDukkaniDAL.Interfaces;
using PlakDukkaniData.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniDAL.Concreties
{
    public class BaseDal<T> : IBaseDal<T> where T : BaseEntity
    {
        PlakDbContext _context;
        public void Add(T entity)
        {
            using (_context=new PlakDbContext())
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
        }

        public ICollection<T> GetAll()
        {
            using (_context=new PlakDbContext())
            {
                return _context.Set<T>().ToList();
                
            }
        }

        public ICollection<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            using (_context = new PlakDbContext())
            {
                return _context.Set<T>().Where(expression).ToList();

            }
        }

        public void Remove(T entity)
        {
            using (_context = new PlakDbContext())
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (_context = new PlakDbContext())
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
        }
    }
}
