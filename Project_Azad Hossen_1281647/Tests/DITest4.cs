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
    internal class DITest4
    {
        public void Run(IRepositoryFactory factory)
        {
            Console.WriteLine("========Insert=======");
            IGenericRepository<Service> repo = factory.GetRepo<Service>();
            repo.Add(new Service { Id = 1, Warrenty = "Life Time Service Warrenty", ReturnBack = "15 Days", noServicing=NoServicing.Burnt });
            repo.AddRange(new Service[]
            {
                new Service { Id=2,Warrenty="Life Time Service Warrenty",ReturnBack="10 Days",noServicing=NoServicing.Broken },
                new Service { Id=3,Warrenty=" Only 6 Month",ReturnBack="20 Days",noServicing=NoServicing.Broken}
            });
            repo.Get()
                .ToList()
                .ForEach(s => Console.WriteLine($"Id: {s.Id},Warrenty: {s.Warrenty},Return Back: {s.ReturnBack},No Servicing: {s.noServicing}"));
            //Update
            Console.WriteLine();
            Console.WriteLine("==========Update=========");
            var Service=repo.Get(2);
            Service.Warrenty = "Only 1 Year Service Warrenty";
            repo.Update(Service);
            repo.Get()
            .ToList()
            .ForEach(s => Console.WriteLine($"Id: {s.Id},Warrenty: {s.Warrenty},Return Back: {s.ReturnBack},No Servicing: {s.noServicing}"));
            //Delete
            Console.WriteLine();
            Console.WriteLine("==========Delete=========");
            repo.Delete(3);
            repo.Get()
                .ToList ()
                .ForEach(s => Console.WriteLine($"Id: {s.Id},Warrenty: {s.Warrenty},Return Back: {s.ReturnBack},No Servicing: {s.noServicing}"));


        }
    }
}
