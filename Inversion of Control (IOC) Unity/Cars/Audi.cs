using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inversion_of_Control__IOC__Unity.Interfaces;

namespace Inversion_of_Control__IOC__Unity.Cars
{
    public class Audi: ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }
}
