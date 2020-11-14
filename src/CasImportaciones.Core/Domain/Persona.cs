using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasImportaciones.Core.Domain
{
    [Table("Persona")]
    public class Persona
    {
        [Key]
        public int IdUsuario { get; set; }
        public int Cedula { get; set; }
        [StringLength(40)]
        public string PrimerNombre { get; set; }
        [StringLength(40)]
        public string SegundoNombre { get; set; }
        [StringLength(40)]
        public string PrimerApellido { get; set; }
        [StringLength(40)]
        public string SegundoApellido { get; set; }
        [StringLength(30)]
        public string Correo { get; set; }
        public double Telefono { get; set; }
        [StringLength(30)]
        public string Direccion { get; set; }
    }
}