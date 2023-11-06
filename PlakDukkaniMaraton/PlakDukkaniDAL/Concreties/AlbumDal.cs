using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
    public class AlbumDal : IAlbumDAl
    {
        PlakDbContext _context;
        public void Add(Album entity)
        {
            using (_context = new PlakDbContext())
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
        }

        public ICollection<Album> GetAll()
        {
            using (_context = new PlakDbContext())
            {
                return _context.Set<Album>().ToList();

            }
        }

        public ICollection<Album> GetByCondition(Expression<Func<Album, bool>> expression)
        {
            using (_context = new PlakDbContext())
            {
                return _context.Set<Album>().Where(expression).ToList();

            }
        }

        public Album GetById(int id)
        {
            using (_context = new PlakDbContext())
            {
                return _context.Set<Album>().Find(id);

            }
        }

        public void Remove(Album entity)
        {
            using (_context = new PlakDbContext())
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }

        public ICollection<Album> Top10(int adet)
        {
            using (_context = new PlakDbContext())
            {
                return _context.Set<Album>().OrderByDescending(x => x.RegisterDate).Take(adet).ToList();

            }
        }

        public void Update(Album entity)
        {
            using (_context = new PlakDbContext())
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
        }

    }
}
