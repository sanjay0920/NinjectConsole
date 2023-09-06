using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using System.Reflection;

namespace NinjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ninject.StandardKernel class.
            StandardKernel _Kernal = new StandardKernel();

            //load Modules
            _Kernal.Load(Assembly.GetExecutingAssembly());

            //Gets an instance of the specified service. 
            IProduct _products = _Kernal.Get<IProduct>();

            //Ninject will inject DL object to BL 
            BL objbl = new BL(_products);

            //calling method of BL from that Dependency 
            objbl.Insert(); 

            Console.ReadLine();
        }
    }
}
