using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Factory
{
    public class TaxCollecionSchemeAnnexThreeFactory : TaxCollectionSchemeFactory
    {
        public override TaxCollectionScheme GetCollectionSchemeTax(TaxType taxType, double grossBilling)
        {
            switch (taxType)
            {
                case TaxType.INSS:
                    return new AnnexThreeINSSTax(grossBilling);
                case TaxType.IRRF:
                    return new AnnexThreeIRRFTax(grossBilling);
                case TaxType.DAS:
                    return new AnnexThreeDASTax(grossBilling);
                default:
                    throw new ArgumentException("Esse tipo de imposto não se aplica ao Anexo 3.");
            }
        }
    }
}
