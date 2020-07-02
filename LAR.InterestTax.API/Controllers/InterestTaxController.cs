using LAR.InterestTax.API.Configuration;
using LAR.InterestTax.API.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LAR.InterestTax.API.Controllers
{
    /// <summary>
    /// This controller is responsible for providing the Interest Tax resource
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class InterestTaxController : ControllerBase
    {
        private const decimal DEFAULT_INTEREST_TAX_VALUE = 0.01M;

        private readonly AppOptions _options;

        public InterestTaxController(
            AppOptions options
        )
        {
            _options = options;
        }

        /// <summary>
        /// Method to get the interest tax value
        /// </summary>
        /// <returns> a decimal parameter representing the interest tax value</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return new GetInterestTaxResponse()
                {
                    InterestTax = _options.InterestTaxValue > 0 ? _options.InterestTaxValue : DEFAULT_INTEREST_TAX_VALUE
                };
            }
            catch (Exception)
            {
                return new ResponseBase(500, "Ocorreu um erro desconhecido. Tente novamente e se " +
                                             "o erro persistir entre em contato com o administrador da API.");
            }
        }
    }
}
