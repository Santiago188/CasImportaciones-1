using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasImportaciones.Core.Domain
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [StringLength(80)]
        public string Descripcion { get; set; }
    }
}