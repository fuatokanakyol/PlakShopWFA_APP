using PlakDukkaniData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniDAL.Interfaces
{
    public interface IAlbumDAl :IBaseDal<Album>
    {
        public Album GetById(int id);

        ICollection<Album> Top10(int adet);
    }
}
