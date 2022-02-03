using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Interfaces;

namespace DesignPattern.AbstractFactory.Domain.Products.Abstractions
{
    public abstract class TaxCollectionSchema : ITaxCalculation
    {
        public TaxCollectionSchemaType Type { get; set; }
        public string Description { get; set; }

        public TaxCollectionSchema(TaxCollectionSchemaType type, string description)
        {
            Type = type;
            Description = description;
        }

        public abstract double CalculateTax();
    }
}
