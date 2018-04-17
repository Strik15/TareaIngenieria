using Datos.Persistencia.Core;
using Datos.Persistencia.Repositorios;
using Dominio.Contratos;
using Dominio.Core;

namespace Datos.Persistencia.Implementacion{

    public class AdministradorRepositorio : RepositorioBase<Administrador>, IAdministradorRepositorio {

        public AdministradorRepositorio(IContextoUnidadDeTrabajo unidadDeTrabajo):base(unidadDeTrabajo) {

        }

    }
}
