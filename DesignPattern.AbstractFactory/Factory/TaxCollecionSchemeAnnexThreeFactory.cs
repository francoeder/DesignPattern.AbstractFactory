using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products;

namespace DesignPattern.AbstractFactory.Factory
{
    public class TaxCollecionSchemeAnnexThreeFactory : TaxCollectionSchemeFactory
    {
        public override (string, double) CalculateTax(TaxType taxType, double grossBilling)
        {
            switch (taxType)
            {
                case TaxType.INSS:
                    var inssTax = new AnnexThreeINSSTax();
                    return (inssTax.Description, grossBilling * inssTax.Aliquot);
                case TaxType.IRRF:
                    var irrfTax = new AnnexThreeIRRFTax();
                    return (irrfTax.Description, grossBilling * irrfTax.Aliquot);
                case TaxType.DAS:
                    var dasTax = new AnnexThreeDASTax();
                    return (dasTax.Description, grossBilling * dasTax.Aliquot);
                default:
                    throw new ArgumentException("Esse tipo de imposto não se aplica ao Anexo 3.");
            }
        }
    }
}
