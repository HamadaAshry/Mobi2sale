using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Application.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Api.MiddleWare {
    public class ErrorhandlingMiddleware {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorhandlingMiddleware> _logger;

        public ErrorhandlingMiddleware (RequestDelegate next, ILogger<ErrorhandlingMiddleware> logger) {
            this._next = next;
            this._logger = logger;
        }

        public async Task Invoke (HttpContext context) {
            try {
                await _next (context);
            } catch (System.Exception ex) {

                await HandleExceptionAsync (context, ex, _logger);
            }

        }

        private async Task HandleExceptionAsync (HttpContext context, Exception ex, ILogger<ErrorhandlingMiddleware> logger) {
            object errors = null;

            switch (ex) {
                case RestException re:
                    logger.LogError (ex, "REST ERROR");
                    errors = re.Errors;
                    context.Response.StatusCode = (int) re.Code;
                    break;
                case Exception e:
                    logger.LogError (ex, "SERVER ERROR");
                    //Will be changed upon Production
                    errors = string.IsNullOrWhiteSpace (e.Message) ? "Something Wrong Happened.Please Contact the support!" : e.Message;
                    context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
                    break;
            }

            context.Response.ContentType = "application/json";
            if (errors != null) {
                var result = JsonSerializer.Serialize (new { errors });
                await context.Response.WriteAsync (result);
            }
        }
    }
}