using ArgoX3API.WebAPI;
using Custom.ArgoX3API.Infrastructure;

// Configurazione host base in ArgoX3API.WebApi.Shared (submodule): qui solo cio' che e' specifico del cliente.
var builder = WebApplication.CreateBuilder(args);

await builder.AddArgoX3ApiCoreAsync();

// Servizi del cliente: dopo quelli base, cosi' il UnitOfWork custom sostituisce quello base
builder.Services.RegisterCustomServices();

var app = builder.Build();

app.UseArgoX3ApiCore();

app.Run();