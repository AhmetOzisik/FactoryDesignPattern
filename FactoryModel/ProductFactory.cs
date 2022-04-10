using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryModel
{
   public class ProductFactory
    {
        private IProductA product;
        public enum ProductTip
        {
            ProductA,
            ProductB
        }
        public IProductA ProductFactoryOlustur(ProductTip productTip)
        {
           
            switch (productTip)
            {
                case ProductTip.ProductA:
                    product= new ProductA1();
                    break;
                case ProductTip.ProductB:
                    product= new ProductA2();
                    break;
                default:
                    Console.WriteLine("geçersiz secim");
                    break;
            }
            return product;
        }
    }
}
