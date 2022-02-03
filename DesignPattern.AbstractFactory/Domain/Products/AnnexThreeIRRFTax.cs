using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Domain.Products
{
    public class AnnexThreeIRRFTax : TaxCollectionSchemaAnnexThree
    {
        public AnnexThreeIRRFTax(double grossBilling) : base(TaxCollectionSchemaType.AnnexThree, "Anexo 3 - IRRF", 0.01373, grossBilling)
        {
        }
    }
}
