using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities {
    class EnterpriseCustomer : ICustomer {

        public string ShowDetails() {
            return "Cliente do tipo ENTERPRISE";
        }

        public string GetVehicle(string vehicle) {
            return $"Cliente do tipo ENTERPRISE usando {vehicle}";
        }
    }
}
