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

        public static async Task Endpoint(HttpContext context)
        {
            string city = context.Request.RouteValues["city"] as string;
            int? pop = null;
            switch ((city ?? "").ToLower())
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
            else
            {
                context.Response.StatusCode = StatusCodes.Status404NotFound;
            }

        }
    }
}