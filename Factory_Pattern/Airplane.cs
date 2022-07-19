using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Airplane : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Private jet ready");
        }
    }
}
