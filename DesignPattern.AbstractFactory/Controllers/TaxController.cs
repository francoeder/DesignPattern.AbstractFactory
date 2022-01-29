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
            var taxCollectionShemeFactory = TaxCollectionSchemeFactory.CreateTaxCollectionSchemaFactory(grossBilling, proLabor);

            (string, double) result = taxCollectionShemeFactory.CalculateTax(taxType, grossBilling);

            return Ok($"{result.Item1} = R${result.Item2}");
        }
    }
}
