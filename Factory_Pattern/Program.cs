using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] arg)
        {
            int tire;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the vehicle's amount of tires for you want to use to ride: 2, 4, or 20");

                input = int.TryParse(Console.ReadLine(), out tire);
            } while (input== false);

            var vehicle = VehicleFactory.GetVehicle(tire);
            vehicle.Drive();
        }
    }

  }