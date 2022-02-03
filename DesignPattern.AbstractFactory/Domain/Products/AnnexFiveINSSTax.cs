using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Domain.Products
{
    public class AnnexFiveINSSTax : TaxCollectionSchemeAnnexFive
    {
        public AnnexFiveINSSTax() : base(TaxCollectionSchemeType.AnnexFive, "Anexo 5 - INSS")
        {
        }

        public override double CalculateTax()
        {
            return 121;
        }
    }
}
