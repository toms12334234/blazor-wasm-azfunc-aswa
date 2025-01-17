using System;
using System.Net;
using System.Net.Http;
using System.Diagnostics;
using System.Threading.Tasks;

using ApiApp.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;

namespace ApiApp
{
    public static class PostHttpTrigger
    {
        private const string GetPosts = "https://public-api.wordpress.com/rest/v1.1/sites/{0}/posts";
        private static HttpClient http = new HttpClient();

        [FunctionName("PostHttpTrigger")]
        [OpenApiOperation(operationId: "posts.get", tags: new[] { "posts" })]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(PostCollection), Description = "The OK response")]
        public static async Task<IActionResult> GetPostsAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "posts")] HttpRequest req,
            ILogger log)
        {
            log?.LogInformation("C# HTTP trigger function processed a request.");

            // string url = string.Format(GetPosts, Environment.GetEnvironmentVariable("SITE__NAME"));
            string url = string.Format(GetPosts, "0wnlife.wordpress.com");
            var requestUri = new Uri(url);

            var json = await http.GetStringAsync(requestUri).ConfigureAwait(false);
            var postCollection = JsonConvert.DeserializeObject<PostCollection>(json);
            Debug.Write("PostCollection: [");
            foreach (var post in postCollection.Posts)
            {
                Debug.Write(post);
                Debug.Write(", ");

            }
            Debug.Write("]");
            return new OkObjectResult(postCollection);
        }
    }
}
