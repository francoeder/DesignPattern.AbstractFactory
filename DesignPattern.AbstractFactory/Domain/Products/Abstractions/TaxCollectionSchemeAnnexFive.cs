using DesignPattern.AbstractFactory.Domain.Enums;

namespace DesignPattern.AbstractFactory.Domain.Products.Abstractions
{
    public abstract class TaxCollectionSchemaAnnexFive : TaxCollectionSchema
    {
        protected TaxCollectionSchemaAnnexFive(TaxCollectionSchemaType type, string description) : base(type, description)
        {
        }
    }
}
