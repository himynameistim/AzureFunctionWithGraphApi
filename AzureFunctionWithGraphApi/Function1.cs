using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using HotChocolate.AzureFunctions;

namespace AzureFunctionWithGraphApi
{
    public class GraphQlApi
    {
        [FunctionName("HttpExample")]
        public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "graphql/{**slug}")] HttpRequest req,
        [GraphQL] IGraphQLRequestExecutor executor,
        ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            return await executor.ExecuteAsync(req);
        }
    }
}
