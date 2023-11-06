using PlakDukkaniData.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniDAL.Interfaces
{
    public interface IBaseDal<T> where T : BaseEntity
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        ICollection<T> GetAll();
        ICollection<T> GetByCondition(Expression<Func<T ,bool>>expression);



    }
}
