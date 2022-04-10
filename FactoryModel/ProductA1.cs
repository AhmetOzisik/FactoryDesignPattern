using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryModel
{
    public class ProductA1 : IProductA
    {
        public void ProductUret()
        {
            Console.WriteLine("ProductA1 üretildi.");
        }
    }
}
