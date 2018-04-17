using Aplicacion.Contrato;
using Dominio.Contratos;
using System.ComponentModel.Composition;
using Utilitarios.IoC;

namespace Aplicacion.Implementacion{

    [Export(typeof(IModule))]

    public class ModuleInit : IModule    {
        public void Initializer(IRegisterModules register) {
            register.RegisterType<IAdministradorServicio,AdministradorServicio>();
        }
    }
}
