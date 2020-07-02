using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAR.InterestTax.API.Response
{
    /// <summary>
    /// Class representing the response of the GET Method of the InterestTax resource
    /// </summary>
    public class GetInterestTaxResponse : ResponseBase
    {
        /// <summary>
        /// Property representing the InterestTax value
        /// </summary>
        public decimal InterestTax { get; set; }
    }
}
