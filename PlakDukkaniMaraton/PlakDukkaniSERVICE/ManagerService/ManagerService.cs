using PlakDukkaniDAL.Concreties;
using PlakDukkaniDAL.Interfaces;
using PlakDukkaniData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniSERVICE.ManagerService
{
    public class ManagerService : IManagerService
    {
        ManagerDal managerDal=new ManagerDal();
        public void Add(Manager entity)
        {
            managerDal.Add(entity);
        }

        public ICollection<Manager> GetAll()
        {
            return managerDal.GetAll();
        }

        public ICollection<Manager> GetByCondition(Expression<Func<Manager, bool>> expression)
        {
            return managerDal.GetByCondition(expression);
        }

        public void Remove(Manager entity)
        {
            managerDal.Remove(entity);
        }

        public void Update(Manager entity)
        {
            managerDal.Update(entity);
        }
    }
}
