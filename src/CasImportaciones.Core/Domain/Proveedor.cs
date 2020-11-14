using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasImportaciones.Core.Domain
{
    [Table("Proveedor")]
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }

        [StringLength(40)]
        public string NombreProveedor { get; set; }

        [StringLength(25)]
        public string Direccion { get; set; }

        public double Telefono { get; set; }

        [StringLength(20)]
        public string Ciudad { get; set; }
    }

}
