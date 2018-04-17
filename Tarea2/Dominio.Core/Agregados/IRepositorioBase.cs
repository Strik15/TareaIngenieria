using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Dominio.Core{
    public interface IRepositorioBase<Entidad> : IDisposable{

        IUnidadDeTrabajocs UnidadDeTrabajo{ get; }

        Entidad Obtener(int id); //Select * FROM ADministrador WHERE ID = ID

        IEnumerable<Entidad> ObtenerTodas();

        IEnumerable<Entidad> Buscar(Expression<Func<Entidad, bool>>predicado);

        Entidad BuscarSingleOrDefault(Expression<Func<Entidad, bool>> predicado);

        void Agregar(Entidad entidad);

        void Eliminar(Entidad entidad);

    }//End interface IRepositorioBase

}//End namespace Dominio.Core
