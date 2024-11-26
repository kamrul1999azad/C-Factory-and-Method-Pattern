using Project_Azad_Hossen_1281647.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Azad_Hossen_1281647.UTils
{
    public static class EntityExtions
    {
        public static string GetDetails(this IEntityBase entity)
        {
            return entity.ToString();
        }
    }
}
