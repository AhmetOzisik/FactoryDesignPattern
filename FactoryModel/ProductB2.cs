using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryModel
{
    public class ProductB2 : IProductB
    {
        public void ProductUret()
        {
            Console.WriteLine("ProductB2 üretildi.");
        }
    }
}
