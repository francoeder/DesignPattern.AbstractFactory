using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Factory
{
    public class TaxCollecionSchemaAnnexFiveFactory : TaxCollectionSchemaFactory
    {
        public override TaxCollectionSchema CreateTaxCollectionSchema(TaxType taxType, double grossBilling)
        {
            switch (taxType)
            {
                case TaxType.INSS:
                    return new AnnexFiveINSSTax();
                case TaxType.DAS:
                    return new AnnexFiveDASTax(grossBilling);
                default:
                    throw new ArgumentException("Esse tipo de imposto não se aplica ao Anexo 5.");
            }
        }
    }
}
