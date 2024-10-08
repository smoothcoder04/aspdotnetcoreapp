using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Platform.Services;

namespace Platform
{
    public class WeatherMiddleware
    {
        private RequestDelegate next;
        //private IResponseFormatter formatter;

        public WeatherMiddleware(RequestDelegate nextDelegate)
        {
            next = nextDelegate;
            //formatter = respFormatter;
        }

        public async Task Invoke(HttpContext context, IResponseFormatter formatter)
        {
            if (context.Request.Path == "/middleware/class")
            {
                await formatter.Format(context, "Middleware class: it is drizzling in Moulton");
            }
            else
            {
                await next(context);
            }
        }
    }
}