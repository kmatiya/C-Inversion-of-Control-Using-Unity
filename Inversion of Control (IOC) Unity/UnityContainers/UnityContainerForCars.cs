using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inversion_of_Control__IOC__Unity.Cars;
using Inversion_of_Control__IOC__Unity.Interfaces;
using Unity;


namespace Inversion_of_Control__IOC__Unity.UnityContainers
{
    public class UnityContainerForCars
    {
        IUnityContainer _container = new UnityContainer();

        public void RegisterType()
        {
            _container.RegisterType<ICar, BMW>();
        }
        
    }
}
