using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microondas;
using Microondas.Data;
using Microsoft.EntityFrameworkCore;
using Microondas.Services.Contratos;
using Microondas.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

string connectionString = builder.Configuration.GetConnectionString("ConexaoBanco");
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IProgramaAquecimentoCustomizadoService, ProgramaAquecimentoCustomizadoService>();


await builder.Build().RunAsync();
