using Datos.Persistencia.Core;
using Dominio.Contratos;
using System.ComponentModel.Composition;
using Utilitarios.IoC;

namespace Datos.Persistencia.Implementacion.Init{

    [Export(typeof(IModule))]

    public class ModuleInit : IModule{
        public void Initializer(IRegisterModules register) {
            register.RegisterType<IContextoUnidadDeTrabajo, ContextoPrincipal>();
            register.RegisterType<IAdministradorRepositorio, AdministradorRepositorio>();
        }
    }
}
