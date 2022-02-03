using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Interfaces;

namespace DesignPattern.AbstractFactory.Domain.Products.Abstractions
{
    public abstract class TaxCollectionScheme : ITaxCalculation
    {
        public TaxCollectionSchemeType Type { get; set; }
        public string Description { get; set; }

        public TaxCollectionScheme(TaxCollectionSchemeType type, string description)
        {
            Type = type;
            Description = description;
        }

        public abstract double CalculateTax(double grossBilling);
    }
}
