using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities {
    class EnterpriseVehicle : IVehicle {
        public string ShowDetails() {
            return "Veículo do tipo ENTERPRISE";
        }
    }
}
