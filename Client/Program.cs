using Blazored.LocalStorage;
using Blazored.Modal;
using Blazored.Modal.Services;
using FreeBelarus.Client.Providers;
using FreeBelarus.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
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
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            builder.Services.AddScoped<IAuthService, AuthService>();
            await builder.Build().RunAsync();
        }
    }
}
