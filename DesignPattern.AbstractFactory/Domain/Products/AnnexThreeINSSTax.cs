using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Domain.Products
{
    public class AnnexThreeINSSTax : TaxCollectionSchemaAnnexThree
    {
        public AnnexThreeINSSTax(double grossBilling) : base(TaxCollectionSchemaType.AnnexThree, "Anexo 3 - INSS", 0.0308, grossBilling)
        {
        }
    }
}
