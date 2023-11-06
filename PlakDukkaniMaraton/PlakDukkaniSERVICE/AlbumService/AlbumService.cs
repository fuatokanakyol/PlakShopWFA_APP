using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using PlakDukkaniDAL.Concreties;
using PlakDukkaniDAL.Context;
using PlakDukkaniData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniSERVICE.AlbumService
{
    public class AlbumService : IAlbumService
    {
        AlbumDal albumdal= new AlbumDal();
        public void Add(Album entity)
        {
            albumdal.Add(entity);
        }

        public ICollection<Album> GetAll()
        {
           return albumdal.GetAll();
        }

        public ICollection<Album> GetByCondition(Expression<Func<Album, bool>> expression)
        {
           return albumdal.GetByCondition(expression);
        }

        public Album GetById(int id)
        {
            return albumdal.GetById(id);
        }

        public void Remove(Album entity)
        {
            albumdal.Remove(entity);
        }

        public ICollection<Album> Top10(int adet)
        {
            return albumdal.Top10(adet);
        }

        public void Update(Album entity)
        {
            albumdal.Update(entity);
        }

    }
}
