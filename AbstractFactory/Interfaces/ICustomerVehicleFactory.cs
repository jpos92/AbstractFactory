using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories {
    public interface ICustomerVehicleFactory {

        public ICustomer CreateCustomer();
        public IVehicle CreateVehicle();
    }
}
