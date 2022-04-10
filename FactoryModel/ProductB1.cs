using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryModel
{
    public class ProductB1 : IProductB
    {
        public void ProductUret()
        {
            Console.WriteLine("ProductB1 üretildi.");
        }
    }
}
