using PlakDukkaniData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniSERVICE.ManagerService
{
    public interface IManagerService
    {
        void Add(Manager entity);
        void Remove(Manager entity);
        void Update(Manager entity);
        ICollection<Manager> GetAll();
        ICollection<Manager> GetByCondition(Expression<Func<Manager, bool>> expression);
    }
}
