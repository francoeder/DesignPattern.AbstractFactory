using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Factory
{
    public class TaxCollecionSchemeAnnexThreeFactory : TaxCollectionSchemeFactory
    {
        public override TaxCollectionScheme GetCollectionSchemeTax(TaxType taxType)
        {
            switch (taxType)
            {
                case TaxType.INSS:
                    return new AnnexThreeINSSTax();
                case TaxType.IRRF:
                    return new AnnexThreeIRRFTax();
                case TaxType.DAS:
                    return new AnnexThreeDASTax();
                default:
                    throw new ArgumentException("Esse tipo de imposto não se aplica ao Anexo 3.");
            }
        }
    }
}
