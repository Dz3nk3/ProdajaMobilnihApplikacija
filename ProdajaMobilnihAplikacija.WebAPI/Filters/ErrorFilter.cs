using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Rent_A_Car.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Filters
{
    public class ErrorFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            //base.OnException(context);
            if (context.Exception is UserException)
            {
                context.ModelState.AddModelError("ERROR", context.Exception.Message);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else
            {
                context.ModelState.AddModelError("ERROR", context.Exception.Message);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            context.Result = new JsonResult(context.ModelState);
        }
    }
}
