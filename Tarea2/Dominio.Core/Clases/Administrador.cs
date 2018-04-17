using System.ComponentModel.DataAnnotations;

namespace Dominio.Core{
    public class Administrador {

        public int AdministradorId { get; set;}
        [Required, StringLength(25)]
        public string AdministradorNombre { get; set; }
        [Required, StringLength(25)]
        public string AdministradorContrasenna { get; set; }
        [Required, StringLength(25)]
        public string AdministradorCorreo { get; set; }

    }//End class Administrador

}//End namespace Dominio.Core.Clases
