using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryModel
{
    public class ProductA2 : IProductA
    {
        public void ProductUret()
        {
            Console.WriteLine("ProductA2 üretildi.");
        }
    }
}
