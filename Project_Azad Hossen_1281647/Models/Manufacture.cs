using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Azad_Hossen_1281647.Models
{
    public class Manufacture : IEntityBase
    {
        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
