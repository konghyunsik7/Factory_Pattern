﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Your RR is ready sir");
        }
    }
}
