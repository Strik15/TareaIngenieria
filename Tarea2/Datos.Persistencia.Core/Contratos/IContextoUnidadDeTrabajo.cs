using System;
using Dominio.Core;
using System.Data.Entity;

namespace Datos.Persistencia.Core{

    public interface IContextoUnidadDeTrabajo:IUnidadDeTrabajocs, IDisposable {

        IDbSet<Administrador> administradores { get; }

        IDbSet<Entidad> Set<Entidad>() where Entidad: class;

        void Attach<Entidad>(Entidad item) where Entidad : class;

        void SetModified<Entidad>(Entidad item) where Entidad : class;


    }//End interface IContextoUnidadDeTrabajo

}//End namespace Datos.Persistencia.Core.Contratos
