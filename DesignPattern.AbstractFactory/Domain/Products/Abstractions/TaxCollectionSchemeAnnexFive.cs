using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Interfaces;

namespace DesignPattern.AbstractFactory.Domain.Products.Abstractions
{
    public abstract class TaxCollectionSchemeAnnexFive : TaxCollectionScheme
    {
        protected TaxCollectionSchemeAnnexFive(TaxCollectionSchemeType type, string description) : base(type, description)
        {
        }
    }
}
