using PlakDukkaniDAL.Context;
using PlakDukkaniDAL.Interfaces;
using PlakDukkaniData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniDAL.Concreties
{
    public class ManagerDal : IManagerDal
    {
        PlakDbContext _context;
        public void Add(Manager entity)
        {
            using (_context = new PlakDbContext())
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
        }

        public ICollection<Manager> GetAll()
        {
            using (_context = new PlakDbContext())
            {
                return _context.Set<Manager>().ToList();

            }
        }

        public ICollection<Manager> GetByCondition(Expression<Func<Manager, bool>> expression)
        {
            using (_context = new PlakDbContext())
            {
                return _context.Set<Manager>().Where(expression).ToList();

            }
        }

        public void Remove(Manager entity)
        {
            using (_context = new PlakDbContext())
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }

        public void Update(Manager entity)
        {
            using (_context = new PlakDbContext())
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
        }
    }
}
