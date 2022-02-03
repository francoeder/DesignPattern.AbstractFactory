using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Domain.Products
{
    public class AnnexThreeINSSTax : TaxCollectionSchemeAnnexThree
    {
        public AnnexThreeINSSTax(double grossBilling) : base(TaxCollectionSchemeType.AnnexThree, "Anexo 3 - INSS", 0.0308, grossBilling)
        {
        }
    }
}
