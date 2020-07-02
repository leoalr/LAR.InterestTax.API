using LAR.InterestTax.API.Response;
using Microsoft.AspNetCore.Mvc;
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

        /// <summary>
        /// Method to get the interest tax value
        /// </summary>
        /// <returns> a decimal parameter representing the interest tax value</returns>
        [HttpGet]
        public async Task<GetInterestTaxResponse> Get()
        {
            return new GetInterestTaxResponse()
            {
                InterestTax = DEFAULT_INTEREST_TAX_VALUE
            };
        }
    }
}
