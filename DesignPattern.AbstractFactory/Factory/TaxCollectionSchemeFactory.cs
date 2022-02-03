using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Factory
{
    public abstract class TaxCollectionSchemaFactory
    {
        public abstract TaxCollectionSchema CreateTaxCollectionSchema(TaxType taxType, double grossBilling);

        public static TaxCollectionSchemaFactory CreateTaxCollectionSchemaFactory(double grossBilling, double proLabor)
        {
            var proLaborInPercent = proLabor / grossBilling;

            if (proLaborInPercent < 0.28)
            {
                return new TaxCollecionSchemaAnnexFiveFactory();
            }
            else if (proLaborInPercent >= 0.28)
            {
                return new TaxCollecionSchemaAnnexThreeFactory();
            } else
            {
                throw new ArgumentException("Esquema de Cobrança de Impostos Não Implementado.");
            }
        }
    }
}
