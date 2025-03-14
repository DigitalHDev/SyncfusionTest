using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SyncfusionTest;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzYyOTA0OEAzMjM4MmUzMDJlMzBSb0JYa1lFdDhteVZXVEl4cmw4amh0VHVYNkpRaWRBTnRLSFUyb1pKUnNFPQ==");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7279/") });
builder.Services.AddSingleton(sp =>
{
    var config = sp.GetRequiredService<IConfiguration>();
    return new clsState(config["ODataUrl"] + "odata");
});

builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();
