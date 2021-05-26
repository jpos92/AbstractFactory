using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities {
    class IndividualVehicle : IVehicle {
        public string ShowDetails() {
            return "Veículo do tipo INDIVIDUAL";
        }
    }
}
