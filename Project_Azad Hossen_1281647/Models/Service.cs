using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Azad_Hossen_1281647.Models
{
    public enum NoServicing {Broken,Burnt }
    public class Service : IEntityBase
    {
        public int Id { get; set; }
        public string Warrenty { get; set; }
        public string ReturnBack { get; set; }
        public NoServicing noServicing { get; set; }

    }
}
