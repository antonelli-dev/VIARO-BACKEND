using VIARO.Domain.Entities;

namespace School.Domain.Entities
{
    public class AlumnoGrado : BaseEntity
    {
        public int AlumnoId { get; set; }
        public Alumno? Alumno { get; set; }
        public int GradoId { get; set; }
        public Grado? Grado { get; set; }
        public string Seccion { get; set; } = string.Empty;
    }
}
