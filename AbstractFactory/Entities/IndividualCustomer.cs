using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities {
    class IndividualCustomer : ICustomer {
        public string ShowDetails() {
            return "Cliente do tipo INDIVIDUAL";
        }
    }
}
