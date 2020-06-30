using Microsoft.AspNetCore.Mvc;

namespace LAR.InterestTax.API.Controllers
{
    /// <summary>
    /// This controller is responsible for providing the Interest Tax resource
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class InterestTaxController : ControllerBase
    {
        /// <summary>
        /// Method to get the interest tax value
        /// </summary>
        /// <returns> a decimal parameter representing the interest tax value</returns>
        [HttpGet] public decimal Get()
        {
            return 0.01M;
        }
    }
}
