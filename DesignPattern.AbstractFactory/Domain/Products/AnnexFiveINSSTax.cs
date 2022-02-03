using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Domain.Products
{
    public class AnnexFiveINSSTax : TaxCollectionSchemeAnnexFive
    {
        public AnnexFiveINSSTax() : base(TaxCollectionSchemeType.AnnexFive, "Anexo 5 - INSS")
        {
        }

        public override double CalculateTax(double grossBilling) // TODO: Apply Interface Segregation Principle, because grossBilling was not necessary here
        {
            return 121;
        }
    }
}
