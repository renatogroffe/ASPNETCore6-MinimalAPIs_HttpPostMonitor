using System.Text.Json;
using HttpPostMonitor.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/monitor", (object data) => 
    {
        app.Logger.LogInformation($"HttpPostMonitor | Conteúdo recebido: " +
            Environment.NewLine +
            JsonSerializer.Serialize(data,
                options: new() { WriteIndented = true }));
        return new ResultadoMonitor() { Data = data };
    });

app.Run();