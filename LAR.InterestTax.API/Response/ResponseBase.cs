using System.Collections.Generic;
using System.Linq;

namespace LAR.InterestTax.API.Response
{
    public abstract class ResponseBase
    {
        public ResponseBase()
        {
            ErrorMessages = new List<string>();
        }

        /// <summary>
        /// A boolean property representing the success of the operation
        /// </summary>
        public bool Success => ErrorMessages.Count() == 0;

        /// <summary>
        /// An array of string messages representing possible errors ocurred during the operation
        /// </summary>
        public IEnumerable<string> ErrorMessages { get; set; }
    }
}
