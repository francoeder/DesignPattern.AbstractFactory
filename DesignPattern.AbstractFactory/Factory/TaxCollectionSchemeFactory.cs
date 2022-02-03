using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Domain.Products.Abstractions;

namespace DesignPattern.AbstractFactory.Factory
{
    public abstract class TaxCollectionSchemeFactory
    {
        public abstract TaxCollectionScheme GetCollectionSchemeTax(TaxType taxType, double grossBilling);

        public static TaxCollectionSchemeFactory CreateTaxCollectionSchemaFactory(double grossBilling, double proLabor)
        {
            var proLaborInPercent = proLabor / grossBilling;

            if (proLaborInPercent < 0.28)
            {
                return new TaxCollecionSchemeAnnexFiveFactory();
            }
            else if (proLaborInPercent >= 0.28)
            {
                return new TaxCollecionSchemeAnnexThreeFactory();
            } else
            {
                throw new ArgumentException("Esquema de Cobrança de Impostos Não Implementado.");
            }
        }
    }
}
