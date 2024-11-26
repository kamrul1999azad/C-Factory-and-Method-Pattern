using Project_Azad_Hossen_1281647.Models;
using Project_Azad_Hossen_1281647.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Azad_Hossen_1281647.Factories
{
    public interface IRepositoryFactory
    {
        IGenericRepository<T> GetRepo<T>() where T : IEntityBase, new();
    }
}
