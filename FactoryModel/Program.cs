using System;

namespace FactoryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductFactory productFactory = new ProductFactory();
            //IProductA product=productFactory.ProductFactoryOlustur(ProductFactory.ProductTip.ProductB);
            //product.ProductUret();
            FactoryA factoryA = new FactoryA();
            IProductA productA= factoryA.FabrikaUretA();
            productA.ProductUret();
            IProductB productB = factoryA.FabrikaUretB();
            productB.ProductUret();
        }
    }
}
