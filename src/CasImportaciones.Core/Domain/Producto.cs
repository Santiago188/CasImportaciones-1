using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasImportaciones.Core.Domain
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        [StringLength(15)]
        public string Refertencia { get; set; }
        [StringLength(40)]
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        [StringLength(15)]
        public string Marca { get; set; }

    }
}
