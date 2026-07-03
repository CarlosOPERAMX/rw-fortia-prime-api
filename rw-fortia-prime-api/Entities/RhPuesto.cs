using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rw_fortia_prime_api.Entities;


[Table("RH_PUESTO")]
public partial class RhPuesto
{
    [Column("CLA_PUESTO")]
    [Key]
    public int ClaPuesto { get; set; }

    [Column("CLA_EMPRESA")]
    public int ClaEmpresa { get; set; }

    [Column("NOM_PUESTO")]
    public string NomPuesto { get; set; }
}
