using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryModel
{
    public class FactoryA : IFactory
    {
        private IProductA ProductA;
        private IProductB productB;
        

        public IProductA FabrikaUretA()
        {
            ProductA = new ProductA1();
            return ProductA;
        }

        public IProductB FabrikaUretB()
        {
            productB = new ProductB1();
            return productB;
        }
    }
}
