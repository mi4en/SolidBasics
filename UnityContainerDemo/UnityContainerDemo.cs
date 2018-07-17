using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace UnityContainerDemo
{
    class UnityContainerDemo
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver(new BMW());
            driver.RunCar();

            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, Ford>();
            container.RegisterType<ICar, AUDI>();

            Driver drv = container.Resolve<Driver>();
            drv.RunCar();
            driver.RunCar();
        }
    }
}
