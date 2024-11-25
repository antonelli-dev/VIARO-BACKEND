using System.ComponentModel.DataAnnotations;

namespace School.Application.DTOs
{
    public class AlumnoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
    }
}
