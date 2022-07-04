namespace HttpPostMonitor.Models;

public class ResultadoMonitor
{
    public string Mensagem { get; init; } = "Dados recebidos e processados com sucesso!";
    public object? Data { get; set; }
}