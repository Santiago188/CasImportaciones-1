using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasImportaciones.Core.Domain
{
    [Table("Inventario")]
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }
        [StringLength(15)]
        public string Referencia { get; set; }
        public string Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}