using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing_Service
{
    public class CheckBrowserMiddlewere
    {
        private readonly RequestDelegate _next;



        public CheckBrowserMiddlewere(RequestDelegate next)
        {
            _next = next;
       

        }

        public Task Invoke(HttpContext context)
        {

          /*  if (context.Response.HasStarted)
            {

            }*/
            
                var dataAbout = context.Request.Headers["User-Agent"].ToString();
                var chi_cha = context.Request.Headers["sec-ch-ua"].ToString();
                char[] spliter = { ';', ',' };
                string[] table_string = chi_cha.Split(spliter);
                int searching = 0;

                foreach (string str in table_string)
                {
                    if (str.Contains("IE") || str.Contains("EdgeChromium") || str.Contains("Edge") || dataAbout.Contains("Trident"))
                    {
                        searching++;

                    }
                }

            if (searching > 0)
            {      
                 context.Response.WriteAsync("YOU DONT HAVE GOOD BROWSER");
                 return _next(context);  
            }
            else
            {
                context.Response.WriteAsync($"<p>Your user-agent: {dataAbout}</p>");

                if (dataAbout.Contains("Firefox")) { context.Response.WriteAsync($"<p>Your Browser: Firefox</p>"); }
                else { context.Response.WriteAsync($"<p>Your Browser: {table_string[0]}</p>"); }
                return _next(context);

            }
        }
    }
        public static class CheckBrowserMiddlewereExtensions
        {
            public static IApplicationBuilder CheckBrowserMiddlewere(this IApplicationBuilder bulider) 
            {
                return bulider.UseMiddleware<CheckBrowserMiddlewere>();
            }

        }

}

