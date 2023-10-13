using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Registro
    {
        [Key]
        public string Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }

        //public string[] Roles { get; set; }
    }
}
