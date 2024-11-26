using Project_Azad_Hossen_1281647.Factories;
using Project_Azad_Hossen_1281647.Models;
using Project_Azad_Hossen_1281647.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Azad_Hossen_1281647
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mobile Phone:");
            DITest1 di1= new DITest1();
            di1.Run(new RepositoryFactoryImpl());
            Console.WriteLine();
            Console.WriteLine("Manufacturer Contact Info:");
            Console.WriteLine("======================");
            DITest2 di2 = new DITest2();
            di2.Run(new RepositoryFactoryImpl());
            Console.WriteLine();
            Console.WriteLine("Customer Info");
            Console.WriteLine("====================");
            RepositoryFactoryImpl di3 = new RepositoryFactoryImpl();
            DITest3 t3 = new DITest3(di3.GetRepo<Customers>());
            t3.RunCustomers();
            Console.WriteLine("Services");
            Console.WriteLine("====================");
            DITest4 di4 = new DITest4();
            di4.Run(new RepositoryFactoryImpl());

            Console.ReadLine();
        }
    }
}
