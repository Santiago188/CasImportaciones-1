using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasImportaciones.Core.Domain
{
    [Table("OrdenVenta")]
    public class OrdenVenta
    {
        [Key]
        public int IdVenta { get; set; }

        public DateTime FechaVenta { get; set; }

        [StringLength(80)]
        public int Cantidad { get; set; }

        public double ValorTotal { get; set; }
    }

}
