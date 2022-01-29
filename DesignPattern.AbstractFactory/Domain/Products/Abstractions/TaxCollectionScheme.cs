using DesignPattern.AbstractFactory.Domain.Enums;

namespace DesignPattern.AbstractFactory.Domain.Products.Abstractions
{
    public abstract class TaxCollectionScheme
    {
        public TaxCollectionSchemeType Type { get; set; }
        public string Description { get; set; }

        public TaxCollectionScheme(TaxCollectionSchemeType type, string description)
        {
            Type = type;
            Description = description;
        }
    }
}
