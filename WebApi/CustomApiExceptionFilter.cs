using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;

namespace WebApi.Filters
{
    public class CustomApiExceptionFilter : ExceptionFilterAttribute
    {
        private readonly ILogger _log;
        public CustomApiExceptionFilter()//:this(System.Web.Mvc.DependencyResolver.Current.GetService<ILogger>())
        {

        }
        public CustomApiExceptionFilter(ILogger log)
        {
            _log = log;
        }
        public override void OnException(HttpActionExecutedContext filterContext)
        {

            var exceptionMessage = string.Empty;
            HttpResponseMessage message=null;
            exceptionMessage = filterContext.Exception.Message;
            //Logging Exception
            WriteLog(filterContext.Exception);
            if (filterContext.Exception is UnauthorizedAccessException)
            {
                message = new HttpResponseMessage(HttpStatusCode.Unauthorized)
                {
                    Content = new StringContent(exceptionMessage),
                    ReasonPhrase = exceptionMessage

                };
            }
            else if (filterContext.Exception is NullReferenceException)
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(exceptionMessage),
                    ReasonPhrase = exceptionMessage

                };
            }
            else 
            {
                message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(exceptionMessage),
                    ReasonPhrase = exceptionMessage

                };
            }
            
            throw new HttpResponseException(message);
        }
        private void WriteLog(Exception exception)
        {
            _log.Error("===================================");
            //   _log.Error("Application Error at on subscription mail sending page");
            _log.Error(" Source : = " + exception.Source);
            _log.Error(" Stack Trace : = " + exception.StackTrace);
            _log.Error(" Message : = " + exception.Message);
            _log.Error("===================================");
        }
    }
}
