using AbstractFactory.ConcreteFactories;
using AbstractFactory.Entities;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory {
    class Program {
        static void Main(string[] args) {

            ICustomerVehicleFactory IF = new IndividualFactory();

            //IF sempre vai retornar clientes e veículos do tipo Individual
            ICustomer ic = IF.CreateCustomer();
            IVehicle iv = IF.CreateVehicle();
            Console.WriteLine(ic.ShowDetails());
            Console.WriteLine(iv.ShowDetails());
            Console.WriteLine();

            ICustomerVehicleFactory EF = new EnterpriseFactory();

            //EF sempre vai retornar clientes e veículos do tipo Enterprise
            Console.WriteLine(EF.CreateCustomer().GetVehicle(EF.CreateVehicle().ShowDetails()));
            Console.WriteLine();
        }
    }
}
