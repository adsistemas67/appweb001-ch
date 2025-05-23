using System.ComponentModel.DataAnnotations;

namespace appweb001.Models
{
    public class Contactos
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string CorreoE { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;

    }
}
