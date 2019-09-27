using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inversion_of_Control__IOC__Unity.Cars;
using Inversion_of_Control__IOC__Unity.Drivers;
using Inversion_of_Control__IOC__Unity.Interfaces;
using Unity;

namespace Inversion_of_Control__IOC__Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();

            //Resolves dependencies and returns the Driver object 
            Driver drv = container.Resolve<Driver>();
            drv.RunCar();

//            Driver driver = new Driver(new BMW());
//            driver.RunCar();
            Console.ReadLine();

        }
    }
}
