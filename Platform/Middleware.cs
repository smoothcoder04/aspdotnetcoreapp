using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

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
                        && context.Request.Query["custom"]== "true")
            {
                await context.Response.WriteAsync("Class-based middleware \n");
            }
            await next(context);
        }
    }
    public class LocationMiddleware
    {
        private RequestDelegate next;
        private MessageOptions options;

        public LocationMiddleware(RequestDelegate nextDelegate, IOptions<MessageOptions> opts)
        {
            this.next = nextDelegate;
            this.options = opts.Value;
        }

        public async Task Invoke(HttpContext context)
        {
            if(context.Request.Path == "/location")
            {
                await context.Response.WriteAsync($"{options.CityName}, {options.CountryName}");
            }
            else
            {
                await next(context);
            }
        }
    }

}