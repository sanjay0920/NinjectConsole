using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectConsole
{
    class BL
    {
        IProduct Product;

        public BL(IProduct objIproduct)
        {
            Product = objIproduct;
        }

        public void Insert()
        {
            Product.InsertProduct();
        }

    }
}
