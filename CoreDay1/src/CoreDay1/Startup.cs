using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace FirstCoreApp
{
    interface IGreetings
    {
        int AddNumber(int num1, int num2);

        string GreetUser(string name);
    }

    class Greetings : IGreetings
    {
        public int AddNumber(int num1, int num2)
        {
            return num1 + num2;
        }

        public string GreetUser(string name)
        {
            return "\n<h1>Welcome to Asp.Net Core " + name +"</h1>";
        }
    }

    public class Startup
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton(new Greetings());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            Greetings obj = new Greetings();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync(obj.GreetUser("Ajeet Kulkarni"));
            });
        }
    }
}
