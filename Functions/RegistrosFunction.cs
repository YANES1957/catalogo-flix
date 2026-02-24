using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace CatalogoFlix.Functions
{
    public static class RegistrosFunction
    {
        private static List<Dictionary<string, string>> registros = new();

        [Function("AdicionarRegistro")]
        public static HttpResponseData AdicionarRegistro(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "registros/adicionar")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);

            try
            {
                var json = req.ReadAsString() ?? ""; // Garantir que nunca será null
                if (string.IsNullOrWhiteSpace(json))
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.WriteString("Erro: corpo da requisição vazio.");
                    return response;
                }

                var registro = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
                if (registro != null)
                {
                    registros.Add(registro);
                    response.WriteString("Registro adicionado com sucesso!");
                }
                else
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.WriteString("Erro: registro inválido.");
                }
            }
            catch
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.WriteString("Erro ao processar o registro.");
            }

            return response;
        }

        [Function("ListarRegistros")]
        public static HttpResponseData ListarRegistros(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "registros/listar")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "application/json");
            response.WriteString(JsonSerializer.Serialize(registros));
            return response;
        }
    }
}
