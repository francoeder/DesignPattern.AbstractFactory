using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Domain.Products
{
    public class AnnexFiveDASTax : TaxCollectionSchemeAnnexFive
    {
        public double Aliquot { get; }
        public AnnexFiveDASTax() : base(TaxCollectionSchemeType.AnnexFive, "Anexo 5 - DAS")
        {
            Aliquot = 0.155;
        }
    }
}
