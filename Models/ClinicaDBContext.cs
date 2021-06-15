using System.Collections.Generic;
using System.Linq;

namespace Clinica_Istea_program.Models
{
    public static class ClinicaDBContext
    {
        public static List<Usuario> Usuarios = new List<Usuario>();
        public static List<Especialidad> Especialidades = new List<Especialidad>();
        public static List<Empleado> Empleados = new List<Empleado>();
        public static List<Material> Materiales = new List<Material>();
        private static string usuarioActivo;// = new Usuario();
        public static int longitudTextoDetDep = 0;
        public static void Cargar()
        {
            Usuario P = new Usuario()
            {
                Nombre = "Juan Perez",
                Contraseña = "12345",
                RespuestaSecreta = "cleo"
            };
            Usuarios.Add(P);

            P = new Usuario()
            {
                Nombre = "Maria Hernadez",
                Contraseña = "istea",
                RespuestaSecreta = "frida"
            };
            Usuarios.Add(P);

            P = new Usuario()
            {
                Nombre = "Martin Molina",
                Contraseña = "6789",
                RespuestaSecreta = "rutila"
            };
            Usuarios.Add(P);


            Especialidad E = new Especialidad()
            {
                Nombre = "Cardiologia",
                Descripcion = " Encargada de patologias cardiologicas"
            };

                Empleado Emp = new Empleado()
                {
                    Id = 1,
                    Nombre = " Juan Pedro",
                    Apellido = "Lopez",
                    Dni = "1112223333",
                    Matricula = "a55555",
                    Telefono = "1130157777",
                    Email = "drrios@gmail.com",
                    Calle = "mujica 555",
                    Localidad = "caba",
                    Provincia = "Bs As",
                    especialidad = E
                };
                Empleados.Add(Emp);
                Material Mat = new Material()
                {
                    Dep = E,
                    Producto = "Gasas",
                    Cantidad = 300

                };
                Materiales.Add(Mat);
                Mat = new Material()
                {
                    Dep = E,
                    Producto = "jeringas",
                    Cantidad = 200

                };
                Materiales.Add(Mat);
            Especialidades.Add(E);

            E = new Especialidad()
            {
                Nombre = "Pediatria",
                Descripcion = " Encargada atencion de chicos"
            };
                Emp = new Empleado()
                {
                    Id = 2,
                    Nombre = " Andrea Rios",
                    Dni = "333335555",
                    Matricula = "b6666",
                    Telefono = "14488999",
                    Email = "drandre@gmail.com",
                    Calle = "tucuman 1235",
                    Localidad = "caba",
                    Provincia = "Bs As",
                    especialidad = E
                };
                Empleados.Add(Emp);
                Mat = new Material()
                {
                    Dep = E,
                    Producto = "Guantes",
                    Cantidad = 500
                };
                Materiales.Add(Mat);
                Mat = new Material()
                {
                    Dep = E,
                    Producto = "paletas",
                    Cantidad = 400

                };
                Materiales.Add(Mat);
                Mat = new Material()
                {
                    Dep = E,
                    Producto = "reactivos",
                    Cantidad = 10

                };
                Materiales.Add(Mat);
            Especialidades.Add(E);
        }

        public static bool ValidarUsuario(string Nombre, string Contraseña)
        {
            return Usuarios.Where(x => x.Nombre == Nombre && x.Contraseña == Contraseña).Any();
        }
        public static bool ValidarPreguntaSecreta(string Nombre, string RespuestaSecreta)
        {
            return Usuarios.Where(x => x.Nombre == Nombre && x.RespuestaSecreta == RespuestaSecreta).Any();
        }

        public static void CambiarContraseña(string Nombre, string ContraseñaNueva)
        {
            Usuario usuarioRecuperacion = Usuarios.Where(x => x.Nombre == Nombre).FirstOrDefault();
            Usuarios.Remove(usuarioRecuperacion);
            usuarioRecuperacion.Contraseña = ContraseñaNueva;
            Usuarios.Add(usuarioRecuperacion);
        }
        public static void SetUsuarioActivo(string usuario)
        {
            usuarioActivo = usuario;
        }
        public static string GetUsuarioActivo()
        {
            return usuarioActivo;
        }

        public static bool ExisteUsuario(string Nombre)
        {
            return Usuarios.Where(x => x.Nombre == Nombre).Any();
        }
        public static List<Especialidad> BuscarDepartamento(string nombre)
        {

            return Especialidades.Where(x => x.Nombre.Contains(nombre)).ToList();
        }
        public static List<Material> BuscarMaterialesDepartamento(string dpto)
        {
            Especialidad d = new Especialidad() {Nombre=dpto };
            return Materiales;
        }
        public static List<string> GetDepartamentos()
        {

            return Especialidades.Select(x=> x.Nombre).ToList();
        }
        public static List<string> GetMateriales()
        {

            return Materiales.Select(x => x.Producto).ToList();
        }
        public static List<string> GetMateriales(Especialidad d)
        {
            return Materiales.Where(x => x.Dep==d).Select(x => x.Producto).ToList();
        }
        public static void setlongitudTextoDetDep(int longitud) {
            longitudTextoDetDep = longitud;
        }
        public static int getlongitudTextoDetDep()
        {
            return longitudTextoDetDep;
        }

        public static bool existeMaterial(string nombre) {
            return Especialidades.Where(x => x.Nombre == nombre).Any();
        }
        public static void addMaterial(string dept, string nombre, int cantidad) {
            Especialidad dpt = new Especialidad() { Nombre = dept };
            Materiales.Add(new Material() {Dep=dpt,Producto= nombre, Cantidad=cantidad });
        }
        public static bool existeEspecialidad(string nombre)
        {
            return Especialidades.Where(x => x.Nombre == nombre).Any();
        }
        public static void addEspecialidad(string nombre, string descripcion)
        {
            Especialidades.Add(new Especialidad() { Nombre = nombre, Descripcion= descripcion });
        }

        public static void actualizarCantidad(Especialidad dpto, string producto, int cantidad)
        {
            Materiales.Where(x => x.Dep == dpto && x.Producto == producto).FirstOrDefault().Cantidad=cantidad;
        }

        public static Empleado getEmpleado(int id)
        {
            return Empleados.Where(x => x.Id == id).FirstOrDefault();
        }

        public static Especialidad getEspecialidad(string nombre)
        {
            return Especialidades.Where(x => x.Nombre == nombre).FirstOrDefault();
        }

    }
}
