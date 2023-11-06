using PlakDukkaniData.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniData.Entities
{
    public class Album :BaseEntity
    {
        public string AlbumName { get; set; }
        public string Musician { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public bool IsItOnSale { get; set; }

       
    }
}
