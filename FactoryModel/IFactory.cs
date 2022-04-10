using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryModel
{
   public interface IFactory
    {
        IProductA FabrikaUretA();
        IProductB FabrikaUretB();
    }
}
