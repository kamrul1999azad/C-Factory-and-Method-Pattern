using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Azad_Hossen_1281647.Models
{
    public class Mobile : IEntityBase
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Launch { get; set; }
        public double Price { get; set; }
    }
}
