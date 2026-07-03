using System.Text.Json.Serialization;

namespace rw_fortia_prime_api.Dtos
{
    public class PuestoDto
    {
        [JsonPropertyName("clave")]
        public int ClaPuesto { get; set; }


        [JsonPropertyName("puesto")]
        public string? NomPuesto { get; set; }
    }
}