using AzureHud.Core.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;


namespace AzureHud.FnApi.WebHooks
{
    public class PullRequests
    {
        [FunctionName(nameof(PullRequestChangedWebHook))]
        public static async Task<IActionResult> PullRequestChangedWebHook(
        [HttpTrigger(AuthorizationLevel.Anonymous, "GET")] PRChangedDto hing,
        ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            log.LogInformation($"Id : {hing.Id}");
            log.LogInformation($"NotificationId Id : {hing.NotificationId}");
            log.LogInformation($"Message : {hing.Message?.Text}");
            log.LogInformation($"Event Type : {hing.EventType}\n");

            return new OkObjectResult(hing);
        }
    }
}
