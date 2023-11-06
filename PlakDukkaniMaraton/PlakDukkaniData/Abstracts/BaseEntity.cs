using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniData.Abstracts
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }=DateTime.Now;
        public DateTime? UpdateDate { get; set; }

    }
}
