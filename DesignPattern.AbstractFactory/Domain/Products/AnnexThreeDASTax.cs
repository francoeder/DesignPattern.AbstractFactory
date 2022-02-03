using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Domain.Products
{
    public class AnnexThreeDASTax : TaxCollectionSchemaAnnexThree
    {
        public AnnexThreeDASTax(double grossBilling) : base(TaxCollectionSchemaType.AnnexThree, "Anexo 3 - DAS", 0.06, grossBilling)
        {
        }
    }
}
