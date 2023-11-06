using PlakDukkaniData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniSERVICE.AlbumService
{
    public interface IAlbumService
    {
        void Add(Album entity);
        void Remove(Album entity);
        void Update(Album entity);
        ICollection<Album> GetAll();
        ICollection<Album> GetByCondition(Expression<Func<Album, bool>> expression);
        Album GetById(int id);
        ICollection<Album> Top10(int adet);
    }
}
