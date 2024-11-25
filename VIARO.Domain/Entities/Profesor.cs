using VIARO.Domain.Entities;

namespace School.Domain.Entities
{
    public class Profesor : BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
    }
}
