
namespace webhooks.Handlers
{
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json.Linq;
    using Microsoft.AspNetCore.WebHooks;

    public class GitHubHandler : Controller
    {
        [GitHubWebHook]
        public IActionResult GitHubRequestHandler(string id, string @event, JObject data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }
    }
}