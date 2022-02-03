using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Domain.Products
{
    public class AnnexFiveINSSTax : TaxCollectionSchemaAnnexFive
    {
        public AnnexFiveINSSTax() : base(TaxCollectionSchemaType.AnnexFive, "Anexo 5 - INSS")
        {
        }

        public override double CalculateTax()
        {
            return 121;
        }
    }
}
