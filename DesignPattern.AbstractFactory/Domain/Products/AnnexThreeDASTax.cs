using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Domain.Products
{
    public class AnnexThreeDASTax : TaxCollectionSchemeAnnexThree
    {
        public AnnexThreeDASTax() : base(TaxCollectionSchemeType.AnnexThree, "Anexo 3 - DAS", 0.06)
        {
        }
    }
}
