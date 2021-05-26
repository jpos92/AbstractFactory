using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces {
    public interface ICustomer {
        public string ShowDetails();
        public string GetVehicle(IVehicle vehicle);
    }
}
