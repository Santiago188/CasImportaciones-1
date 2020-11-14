using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasImportaciones.Core.Domain
{
    [Table("OrdenCompra")]
    public class OrdenCompra
    {
        [Key]
        public int IdCompra { get; set; }

        public string Referencia { get; set; }

        public int Cantidad { get; set; }

        public DateTime FechaCompra { get; set; }
    }
}
