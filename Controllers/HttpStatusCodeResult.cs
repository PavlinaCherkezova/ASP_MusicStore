using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace MusicStore.Controllers
{
    internal class HttpStatusCodeResult : ActionResult
    {
        private HttpStatusCode badRequest;
        private string message;

        public HttpStatusCodeResult(HttpStatusCode badRequest, string message)
        {
            this.badRequest = badRequest;
            this.message = message;
        }
    }
}