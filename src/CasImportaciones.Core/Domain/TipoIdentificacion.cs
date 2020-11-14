using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasImportaciones.Core.Domain
{
    [Table("TipoIdentificacion")]
    public class TipoIdentificacion
    {
        [Key]
        public int IdTipo { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }
    }

}
