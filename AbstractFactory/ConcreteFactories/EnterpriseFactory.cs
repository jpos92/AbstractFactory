using AbstractFactory.Entities;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteFactories {
    class EnterpriseFactory : ICustomerVehicleFactory {
        public ICustomer CreateCustomer() {
            return new EnterpriseCustomer();
        }

        public IVehicle CreateVehicle() {
            return new EnterpriseVehicle();
        }
    }
}
