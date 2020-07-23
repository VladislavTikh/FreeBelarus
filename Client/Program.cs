using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FreeBelarus.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider
                .RegisterLicense("Mjg3NDQ0QDMxMzgyZTMyMmUzMGNYNFdaVEVmTitjbURSNlFveTFXZlJYamRtcFZ0Zi9tbDJpbUxXN3EwRWM9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
