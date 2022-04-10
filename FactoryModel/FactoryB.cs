using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryModel
{
    public class FactoryB : IFactory
    {

        private IProductA ProductA;
        private IProductB productB;
        public IProductA FabrikaUretA()
        {

            ProductA = new ProductA2();
            return ProductA;
        }

        public IProductB FabrikaUretB()
        {
            productB = new ProductB2();
            return productB;
        }
    }
}
