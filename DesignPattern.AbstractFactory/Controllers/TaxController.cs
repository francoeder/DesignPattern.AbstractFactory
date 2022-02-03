using DesignPattern.AbstractFactory.Domain.Enums;
using DesignPattern.AbstractFactory.Factory;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.AbstractFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {

        [Route("calculate")]
        [HttpGet]
        public IActionResult Calculate(TaxType taxType,  double grossBilling, double proLabor)
        {
            var taxCollectionSchemeFactory = TaxCollectionSchemeFactory.CreateTaxCollectionSchemaFactory(grossBilling, proLabor);

            var schemeTax = taxCollectionSchemeFactory.GetCollectionSchemeTax(taxType, grossBilling);
            var taxCalculated = schemeTax.CalculateTax();

            var result = new
            {
                schemeTax.Description,
                taxCalculated,
            };

            return Ok(result);
        }
    }
}
