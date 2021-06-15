namespace Clinica_Istea_program.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Matricula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Calle { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }

        public Especialidad especialidad { get; set; }
    }
}
