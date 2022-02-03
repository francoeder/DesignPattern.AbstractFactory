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
            var taxCollectionSchemaFactory = TaxCollectionSchemaFactory.CreateTaxCollectionSchemaFactory(grossBilling, proLabor);

            var taxCollectionSchema = taxCollectionSchemaFactory.CreateTaxCollectionSchema(taxType, grossBilling);
            var taxCalculated = taxCollectionSchema.CalculateTax();

            var result = new
            {
                taxCollectionSchema.Description,
                taxCalculated,
            };

            return Ok(result);
        }
    }
}
