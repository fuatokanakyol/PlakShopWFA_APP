using PlakDukkaniData.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniData.Entities
{
    public class Manager:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
       
    }
}
