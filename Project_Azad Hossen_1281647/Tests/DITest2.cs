using Project_Azad_Hossen_1281647.Factories;
using Project_Azad_Hossen_1281647.Models;
using Project_Azad_Hossen_1281647.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Azad_Hossen_1281647.Tests
{
    internal class DITest2
    {
        
        public void Run(IRepositoryFactory factory)
        {
            Console.WriteLine("========Insert=======");
            IGenericRepository<Manufacture> repo = factory.GetRepo<Manufacture>();
            repo.Add(new Manufacture { Id = 1, ManufacturerName = "Realme", Contact = "015XXXXXXXX", Email = "realme@gmail.com" });
            repo.AddRange(new Manufacture[]
            {
                new Manufacture { Id=2,ManufacturerName="Xiami",Contact="01658XXXXX",Email="xiami@gmail.com"},
                new Manufacture { Id=3,ManufacturerName="Vivo",Contact="017586XXXXX",Email="vivo@gamil.com"}
            });
            repo.Get()
                .ToList()
                .ForEach(m => Console.WriteLine($"Id: {m.Id},Company Name: {m.ManufacturerName},Contact: {m.Contact},Email: {m.Email}"));
            //Update
            Console.WriteLine();
            Console.WriteLine("======Update======");
            var Manufacture = repo.Get(2);
            Manufacture.Email = "xiami2024@gmail.com";
            repo.Update(Manufacture);
            repo.Get()
            .ToList()
            .ForEach(m => Console.WriteLine($"Id: {m.Id},Manufacture: {m.ManufacturerName},Phone Number: {m.Contact},Price: {m.Email}"));
            //Delete
            Console.WriteLine();
            Console.WriteLine("======Delete======");
            repo.Delete(2);
            repo.Get()
            .ToList()
            .ForEach(m => Console.WriteLine($"Id: {m.Id},Manufacture: {m.ManufacturerName},Phone Number: {m.Contact},Price: {m.Email}"));
        }
    }
}
