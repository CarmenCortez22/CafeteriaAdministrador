using Blazored.LocalStorage;
using CafeteriaAdministrador;
using CafeteriaAdministrador.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44334/api/") });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.cafeteriasv.somee.com/api/") });

builder.Services.AddScoped<UserAuth>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationProvider>();
builder.Services.AddAuthorizationCore();

builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
