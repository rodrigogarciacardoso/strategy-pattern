using Microsoft.AspNetCore.Mvc;
using strategy_pattern.Service;

namespace strategy_pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaxController : ControllerBase
    {
        public TaxController() { }

        [HttpPost]
        public IActionResult CalculateTax(DataCalculateTax dataCalculateTax)
        {
            TaxCalculatorService taxCalculatorService;

            try
            {
                switch (dataCalculateTax.TaxType)
                {
                    case "ICMS":
                        taxCalculatorService = new TaxCalculatorService(new ICMS());
                        break;
                    case "ISS":
                        taxCalculatorService = new TaxCalculatorService(new ISS());
                        break;
                    case "IPI":
                        taxCalculatorService = new TaxCalculatorService(new IPI());
                        break;
                    default:
                        throw new ArgumentException("Tax type is invalid");
                }

                var taxValue = taxCalculatorService.Calculate(dataCalculateTax.Amount);

                return Ok(new { Tax = taxValue });
            }
            catch (Exception ex)
            {
                return BadRequest(new { ErrorMessage = ex.Message });
            }
        }

        public class DataCalculateTax
        {
            public string? TaxType { get; set; }
            public decimal Amount { get; set; }
        }
    }
}
