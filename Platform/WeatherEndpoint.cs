using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Platform
{
    public class WeatherEndpoint
    {
        public static async Task Endpoint(HttpContext context)
        {
            await context.Response.WriteAsync("Endpoint Class: it is cloudy in London");
        }
    }
}