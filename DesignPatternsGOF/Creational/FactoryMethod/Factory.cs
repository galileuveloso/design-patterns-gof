using DesignPatternsGOF.Creational.FactoryMethod.Enums;
using DesignPatternsGOF.Creational.FactoryMethod.Interfaces;

namespace DesignPatternsGOF.Creational.FactoryMethod
{
    public abstract class Factory
    {
        public abstract IService FactoryProduct(ServiceType typeService);
    }
}
