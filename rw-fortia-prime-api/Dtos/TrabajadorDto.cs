using System.Text.Json.Serialization;

namespace rw_fortia_prime_api.Dtos
{
    public class TrabajadorDto
    {
        [JsonPropertyName("clave")]
        public int ClaTrab { get; set; }

        [JsonPropertyName("nombre")]
        public string? NomTrab { get; set; }

        [JsonPropertyName("apellido_paterno")]
        public string? ApPaterno { get; set; }

        [JsonPropertyName("apellido_materno")]
        public string? ApMaterno { get; set; }

        [JsonPropertyName("clave_puesto")]
        public int ClaPuesto { get; set; }

        [JsonPropertyName("puesto")]
        public string NomPuesto { get; set; }
    }
}
