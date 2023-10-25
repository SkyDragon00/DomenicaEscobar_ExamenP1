using System.ComponentModel.DataAnnotations;

namespace DomenicaEscobar_ExamenP1.Models
{
    public class DomenicaEscobar_Tabla
    {
        public int Id { get; set; }
        [Required]
        public string? DEAtributo1 { get; set; }
        public bool DEAtributo2 { get; set; }
        [Range(0.01, 9999.99)]
        public decimal DEAtributo3 { get; set; }
        public DateTime DEFecha { get; set; }
    }
}
