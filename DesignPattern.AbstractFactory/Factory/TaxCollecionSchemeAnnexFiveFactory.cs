using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products;

namespace DesignPattern.AbstractFactory.Factory
{
    public class TaxCollecionSchemeAnnexFiveFactory : TaxCollectionSchemeFactory
    {
        public override (string, double) CalculateTax(TaxType taxType, double grossBilling)
        {
            switch (taxType)
            {
                case TaxType.INSS:
                    var inssTax = new AnnexFiveINSSTax();
                    return (inssTax.Description, 121);
                case TaxType.DAS:
                    var dasTax = new AnnexFiveDASTax();
                    return (dasTax.Description, grossBilling * dasTax.Aliquot);
                default:
                    throw new ArgumentException("Esse tipo de imposto não se aplica ao Anexo 5.");
            }
        }
    }
}
