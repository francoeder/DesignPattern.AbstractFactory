using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Factory
{
    public class TaxCollecionSchemeAnnexFiveFactory : TaxCollectionSchemeFactory
    {
        public override TaxCollectionScheme GetCollectionSchemeTax(TaxType taxType)
        {
            switch (taxType)
            {
                case TaxType.INSS:
                    return new AnnexFiveINSSTax();
                case TaxType.DAS:
                    return new AnnexFiveDASTax();
                default:
                    throw new ArgumentException("Esse tipo de imposto não se aplica ao Anexo 5.");
            }
        }
    }
}
