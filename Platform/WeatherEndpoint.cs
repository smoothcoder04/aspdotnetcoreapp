using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Platform.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Platform
{
    public class WeatherEndpoint
    {
        private IResponseFormatter formatter;

        public WeatherEndpoint(IResponseFormatter responseFormatter)
        {
            formatter = responseFormatter;
        }
        public async Task Endpoint(HttpContext context)
        {
            await formatter.Format(context, "Endpoint class: It is bright and sunny here in Moulton :)");
        }
    }
}