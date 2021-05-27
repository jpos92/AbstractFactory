using AbstractFactory.Entities;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteFactories {
    class IndividualFactory : ICustomerVehicleFactory {
        public ICustomer CreateCustomer() {
            return new IndividualCustomer();
        }

        public IVehicle CreateVehicle() {
            return new IndividualVehicle();
        }
    }
}
