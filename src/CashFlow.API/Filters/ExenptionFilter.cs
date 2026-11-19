using CashFlow.Communication.Responses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CashFlow.API.Filters
{
    public class ExenptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is CashFlowException)
            {
                HandleProjectExeption(context);
            }
            else
            {
                ThrowUnkowError(context);
            }

        }

        private void HandleProjectExeption(ExceptionContext context)
        {
            if (context.Exception is ErrorOnValidationException)
            {
                var ex = (ErrorOnValidationException)context.Exception;
                var errorResponse = new ResponseErrorJsom(ex.Errors);
                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest; // Bad Request
                context.Result = new BadRequestObjectResult(errorResponse);
            }
            else
            {
                var errorResponse = new ResponseErrorJsom(context.Exception.Message);
                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest; // Bad Request
                context.Result = new BadRequestObjectResult(errorResponse);
            }
        }
        

        private void ThrowUnkowError(ExceptionContext context)
        {
            var erroResponse = new ResponseErrorJsom(ResourceErrorMessages.UNKNOWN_ERROR);
            // Handle the exception and set the appropriate response
            context.ExceptionHandled = true;
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError; // Internal Server Error
            context.Result = new ObjectResult(erroResponse);
        }
    }
}
