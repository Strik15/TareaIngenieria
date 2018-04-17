using System.ComponentModel.DataAnnotations;

namespace Aplicacion.Core { 
    public class AdministradorDTO{

        public int AdministradorId { get; set; }
        [Required, StringLength(25)]
        public string AdministradorNombre { get; set; }
        [Required, StringLength(25)]
        public string AdministradorContrasenna { get; set; }
        [Required, StringLength(25)]
        public string AdministradorCorreo { get; set; }

    }//End class AdministradorDTO
}//End namespace Aplicacion.Core
