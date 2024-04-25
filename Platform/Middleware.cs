using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Platform
{
    public class QueryStringMiddleware
    {
        private RequestDelegate next;

        public QueryStringMiddleware(RequestDelegate nextDelegate)
        {
            this.next = nextDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Get
                        && context.Request.Query["custom"] == "true")
            {
                await context.Response.WriteAsync("Class based middleware \n");
            }
            await next(context);
        }
    }

}