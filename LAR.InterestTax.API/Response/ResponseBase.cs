using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAR.InterestTax.API.Response
{
    /// <summary>
    /// Base class to define common properties to all API responses
    /// </summary>
    public class ResponseBase : IActionResult
    {
        /// <summary>
        /// Basic class constructor to initialize ErrorMessages property
        /// </summary>
        public ResponseBase(
            int statusCode = default
        )
        {
            StatusCode = statusCode;
            ErrorMessages = new List<string>();
        }

        /// <summary>
        /// Class constructor which requires mandatory statusCode and errorMessage
        /// </summary>
        /// <param name="statusCode">The StatusCode for the HttpResponse</param>
        /// <param name="errorMessage">An error message describing what happened</param>
        public ResponseBase(
            int statusCode,
            string errorMessage
        )
        {
            StatusCode = statusCode;
            ErrorMessages = new List<string>
            {
                errorMessage
            };
        }

        /// <summary>
        /// A boolean property representing the success of the operation
        /// </summary>
        public bool Success => ErrorMessages.Count() == 0;

        /// <summary>
        /// An array of string messages representing possible errors ocurred during the operation
        /// </summary>
        public List<string> ErrorMessages { get; set; }

        /// <summary>
        /// Status code of the Http Response
        /// </summary>
        private int StatusCode { get; set; }

        /// <summary>
        /// Method that implements IActionResult
        /// </summary>
        /// <param name="context">The called action context</param>
        /// <returns>An awaitable task</returns>
        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(this);

            if (StatusCode != default)
            {
                objectResult.StatusCode = StatusCode;
            }

            await objectResult.ExecuteResultAsync(context);
        }
    }
}
