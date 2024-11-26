using Project_Azad_Hossen_1281647.Models;
using Project_Azad_Hossen_1281647.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Azad_Hossen_1281647.Tests
{
    internal class DITest3
    {
        private IGenericRepository<Customers> repo;
        public DITest3(IGenericRepository<Customers> repo)
        {
            this.repo = repo;
        }
        public void RunCustomers()
        {
            Console.WriteLine("========Insert=======");
            this.repo.Add(new Customers { Id = 1, Name = "Raju",Gender=Gender.Male, Address = "Dhaka", Email = "raju12@gamil.com", Phone = "01752XXXXX" });
            this.repo.AddRange(new Customers[]
            {
                new Customers {Id = 2, Name = "Choyon", Address = "Khulna", Gender = Gender.Male,Phone="01888XXXXX", Email="choyon12@gamil.com" },
                new Customers { Id = 3, Name = "Mim", Address = "Gazipur", Gender = Gender.Female,Phone="01999XXXXX", Email="mim12@gamil.com"}
            });
            this.repo.Get()
                .ToList()
                .ForEach(c => Console.WriteLine($"ID:{c.Id} Name:{c.Name} Address:{c.Address} Gender:{c.Gender} Contact:{c.Phone} Email:{c.Email}"));

            //update
            Console.WriteLine();
            Console.WriteLine("=========Update===========");
            var customers = repo.Get(2);
            customers.Name = "Shuvo";
            repo.Update(customers);
            this.repo.Get()
                .ToList()
                .ForEach(c => Console.WriteLine($"ID:{c.Id} Name:{c.Name} Address:{c.Address} Gender:{c.Gender} Contact:{c.Phone} Email:{c.Email}"));

            //delete
            Console.WriteLine();
            Console.WriteLine("=========Delete===========");
            repo.Delete(1);
            this.repo.Get()
                 .ToList()
                 .ForEach(c => Console.WriteLine($"ID:{c.Id} Name:{c.Name} Address:{c.Address} Gender:{c.Gender} Contact:{c.Phone} Email:{c.Email}"));
            Console.WriteLine();
        }
    }
}
