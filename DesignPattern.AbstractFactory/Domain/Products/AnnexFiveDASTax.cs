using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Domain.Products
{
    public class AnnexFiveDASTax : TaxCollectionSchemaAnnexFive
    {
        public double Aliquot { get; }
        public double GrossBilling { get; set; }

        public AnnexFiveDASTax(double grossBilling) : base(TaxCollectionSchemaType.AnnexFive, "Anexo 5 - DAS")
        {
            Aliquot = 0.155;
            GrossBilling = grossBilling;
        }

        public override double CalculateTax()
        {
            return GrossBilling * Aliquot;
        }
    }
}
