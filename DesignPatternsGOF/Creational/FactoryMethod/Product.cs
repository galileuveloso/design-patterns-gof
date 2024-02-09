using DesignPatternsGOF.Creational.FactoryMethod.Enums;
using DesignPatternsGOF.Creational.FactoryMethod.Interfaces;
using DesignPatternsGOF.Creational.FactoryMethod.Services;

namespace DesignPatternsGOF.Creational.FactoryMethod
{
    public class Product : Factory
    {
        public override IService? FactoryProduct(ServiceType typeService)
        {
            return typeService switch
            {
                ServiceType.Traditional => new Traditional(),
                ServiceType.Premium => new Premium(),
                ServiceType.Master => new Master(),
                ServiceType.Roof => new Roof(),
                _ => null
            };
        }
    }
}
