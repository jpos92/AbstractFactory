using AbstractFactory.ConcreteFactories;
using AbstractFactory.Entities;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory {
    class Program {
        static void Main(string[] args) {

            EnterpriseFactory EF = new EnterpriseFactory();
            IndividualFactory IF = new IndividualFactory();

            //EF sempre vai retornar clientes e veículos do tipo Enterprise
            ICustomer ec = EF.CreateCustomer();
            IVehicle ev = EF.CreateVehicle();
            Console.WriteLine(ec.ShowDetails());
            Console.WriteLine(ev.ShowDetails());
            Console.WriteLine();

            //IF sempre vai retornar clientes e veículos do tipo Individual
            ICustomer ic = IF.CreateCustomer();
            IVehicle iv = IF.CreateVehicle();
            Console.WriteLine(ic.ShowDetails());
            Console.WriteLine(iv.ShowDetails());
            Console.WriteLine();
        }
    }
}
