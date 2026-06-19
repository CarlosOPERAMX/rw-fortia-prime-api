using System.Text.Json.Serialization;

public class PuestoDto
{
    [JsonPropertyName("clave")]
    public int ClaPuesto { get; set; }


    [JsonPropertyName("puesto")]
    public string? NomPuesto { get; set; }
}
