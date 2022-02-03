using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Interfaces;

namespace DesignPattern.AbstractFactory.Domain.Products.Abstractions
{
    public abstract class TaxCollectionSchemeAnnexThree : TaxCollectionScheme
    {
        public double Aliquot { get; set; }
        public double GrossBilling { get; set; }

        protected TaxCollectionSchemeAnnexThree(TaxCollectionSchemeType type, string description, double aliquot, double grossBilling) : base(type, description)
        {
            Aliquot = aliquot;
            GrossBilling = grossBilling;
        }

        public override double CalculateTax() => GrossBilling * Aliquot;
    }
}
