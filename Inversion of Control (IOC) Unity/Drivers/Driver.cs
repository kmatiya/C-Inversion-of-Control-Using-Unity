using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inversion_of_Control__IOC__Unity.Interfaces;

namespace Inversion_of_Control__IOC__Unity.Drivers
{
    public class Driver
    {
         readonly ICar _car = null;

        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile",_car.GetType().Name,_car.Run());
            
        }
    }
}
