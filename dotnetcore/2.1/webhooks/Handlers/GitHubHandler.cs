
namespace webhooks.Handlers
{
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json.Linq;
    using Microsoft.AspNetCore.WebHooks;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public class GitHubHandler
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