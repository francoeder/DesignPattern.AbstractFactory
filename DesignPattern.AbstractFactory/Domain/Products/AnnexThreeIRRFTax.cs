using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Domain.Products
{
    public class AnnexThreeIRRFTax : TaxCollectionSchemeAnnexThree
    {
        public AnnexThreeIRRFTax() : base(TaxCollectionSchemeType.AnnexThree, "Anexo 3 - IRRF", 0.01373)
        {
        }
    }
}
