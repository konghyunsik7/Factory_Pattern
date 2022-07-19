using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tire)
        {
            switch (tire)
            {
                case 4:
                    return new Car();
                case 20:
                    return new Airplane();
                case 2:
                    return new Bicycle();
                default:
                    return new Car();

            }
        }   
    }
}
