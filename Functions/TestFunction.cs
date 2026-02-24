using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace catalogo_flix.Functions
{
    public class TestFunction
    {
        private readonly ILogger _logger;

        public TestFunction(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<TestFunction>();
        }

        [Function("TesteFuncao")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("TesteFuncao foi chamada.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
            response.WriteString("🔥 Azure Function .NET 7 funcionando!");

            return response;
        }
    }
}
