using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Platform
{
    public class Population
    {
        private RequestDelegate next;

        public Population()
        {

        }
        public Population(RequestDelegate nextDelegate)
        {
            this.next = nextDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            string[] parts = context.Request.Path.ToString().Split('/', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2 && parts[0] == "population")
            {
                string city = parts[1];
                int? pop = null;
                switch(city.ToLower())
                {
                    case "london":
                        pop = 8_10_800;
                        break;
                    case "paris":
                        pop = 2_04_100;
                        break;
                    case "monaco":
                        pop = 20_000;
                        break;

                }
                if (pop.HasValue)
                {
                    await context.Response.WriteAsync($"City: {city}, Population: {pop}");
                    return;
                }
            }
            if(next != null)
            {
                await next(context);
            }
        }
    }
}