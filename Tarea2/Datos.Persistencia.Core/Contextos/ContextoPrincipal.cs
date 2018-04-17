using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using Dominio.Core;

namespace Datos.Persistencia.Core{
    public class ContextoPrincipal : DbContext, IContextoUnidadDeTrabajo{

        public ContextoPrincipal() : base("DefaultConnnection") { }//End construct

        //Atributo
        IDbSet<Administrador> _Administrador;

        //Propiedad
        public IDbSet<Administrador> administradores {
            get { return _Administrador ?? (_Administrador = base.Set<Administrador>()); }
        }//End IDbSet<Administrador> administradores 

        public new IDbSet<Entidad> Set<Entidad>() where Entidad : class {
            return base.Set<Entidad>();
        }//End IDbSet<Entidad> Set<Entidad>() where Entidad : class

        public void Attach<Entidad>(Entidad item) where Entidad : class {
            if (Entry(item).State == EntityState.Detached) {
                base.Set<Entidad>().Attach(item);
            }//End if (Entry(item).State == EntityState.Detached) 
        }//End Attach<Entidad>(Entidad item) where Entidad : class

        public void SetModified<Entidad>(Entidad item) where Entidad : class{
            Entry(item).State = EntityState.Modified;
        }//End SetModified<Entidad>(Entidad item) where Entidad : class

    }//End class ContextoPrincipal : DbContext, IContextoUnidadDeTrabajo

}//End namespace Datos.Persistencia.Core
