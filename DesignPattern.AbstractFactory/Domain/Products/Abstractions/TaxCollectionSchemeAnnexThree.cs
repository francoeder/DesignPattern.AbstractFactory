using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Interfaces;

namespace DesignPattern.AbstractFactory.Domain.Products.Abstractions
{
    public abstract class TaxCollectionSchemeAnnexThree : TaxCollectionScheme
    {
        public double Aliquot { get; set; }
        protected TaxCollectionSchemeAnnexThree(TaxCollectionSchemeType type, string description, double aliquot) : base(type, description)
        {
            Aliquot = aliquot;
        }

        public override double CalculateTax(double grossBilling) => grossBilling * Aliquot;
    }
}
