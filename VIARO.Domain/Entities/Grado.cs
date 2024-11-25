using VIARO.Domain.Entities;

namespace School.Domain.Entities
{
    public class Grado : BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;
        public int ProfesorId { get; set; }

        public Profesor? Profesor { get; set; }
    }
}
