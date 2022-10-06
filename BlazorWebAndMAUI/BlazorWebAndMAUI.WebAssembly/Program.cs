using BlazorWebAndMAUI.Shared.Data;
using BlazorWebAndMAUI.WebAssembly;
using BlazorWebAndMAUI.WebAssembly.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<INTKDBRepository, NTKDBRepository>(
    client => client.BaseAddress = new Uri("https://dev5.kompas-xnet.si"));

builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
