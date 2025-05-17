using API_PROGRAMACION_DE_SOFTWARE.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Interfaces;
using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7213/") });

builder.Services.AddScoped<IMaterialService, MaterialService>();

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IReservationService, ReservationService>();

builder.Services.AddScoped<ILoanService, LoanService>();

builder.Services.AddScoped<ILoginService, LoginService>();

builder.Services.AddSingleton<UserSessionService>();

builder.Logging.SetMinimumLevel(LogLevel.Information);

await builder.Build().RunAsync();
