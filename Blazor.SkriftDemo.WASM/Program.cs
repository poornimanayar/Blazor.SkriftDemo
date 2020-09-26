using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.SkriftDemo.WASM.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.SkriftDemo.WASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //create the web assembly host
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            //root component
            builder.RootComponents.Add<App>("app");

            builder.Services.AddHttpClient<IGetWhereAmIService, GetWhereAmIService>();

            await builder.Build().RunAsync();
        }
    }
}
