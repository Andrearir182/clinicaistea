namespace Clinica_Istea_program.Models
{
    public class Material
    {
        public Especialidad Dep { get; set; }
        public string Producto { get; set; }
        

        //GAW: Por que la cantidad es nullable????????
        public int? Cantidad { get; set; }

    }
}
