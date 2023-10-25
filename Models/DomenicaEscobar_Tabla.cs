using System.ComponentModel.DataAnnotations;

namespace DomenicaEscobar_ExamenP1.Models
{
    // Definimos la clase DomenicaEscobar_Tabla
    public class DomenicaEscobar_Tabla
    {
        //Identificar de tipo
        public int Id { get; set; }
        [Required]
        public string? DEAtributo1 { get; set; }
        //Para un atributo numerico
        public bool DEAtributo2 { get; set; }
        [Range(5, 200)]
        public decimal DEAtributo3 { get; set; }
        //Para poder colocar fecha
        public DateTime DEFecha { get; set; }
    }
}
