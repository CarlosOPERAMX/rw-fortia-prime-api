using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rw_fortia_prime_api.Entities
{
    [Table("RH_TRAB")]
    public class RhTrab
    {
        [Column("CLA_TRAB")]
        [Key]
        public int ClaTrab { get; set; }

        [Column("CLA_PUESTO")]
        public int ClaPuesto { get; set; }

        [Column("NOM_TRAB")]
        public string? NomTrab { get; set; }

        [Column("AP_PATERNO")]
        public string? ApPaterno { get; set; }

        [Column("AP_MATERNO")]
        public string? ApMaterno { get; set; }

        [Column("STATUS_TRAB")]
        public char StatusTrab { get; set; }
    }
}
