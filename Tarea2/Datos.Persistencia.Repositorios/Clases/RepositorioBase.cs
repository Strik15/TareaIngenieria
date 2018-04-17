using System;
using System.Collections.Generic;
using Datos.Persistencia.Core;
using Dominio.Core;
using System.Linq;
using System.Linq.Expressions;

namespace Datos.Persistencia.Repositorios{
    public class RepositorioBase<Entidad> : IRepositorioBase<Entidad> where Entidad: class{
        readonly IContextoUnidadDeTrabajo _unidadDeTrabajo;

        public IUnidadDeTrabajocs UnidadDeTrabajo { get { return _unidadDeTrabajo; } }

        public RepositorioBase(IContextoUnidadDeTrabajo unidadDeTrabajo) {
            _unidadDeTrabajo = unidadDeTrabajo;
        }//End RepositorioBase(IContextoUnidadDeTrabajo unidadDeTrabajo) 

        public Entidad Obtener(int id) {
            return _unidadDeTrabajo.Set<Entidad>().Find(id);
        }//End Entidad Obtener(int id) 

        public IEnumerable<Entidad> ObtenerTodas() {
            return _unidadDeTrabajo.Set<Entidad>().ToList();
        }//End IEnumerable<Entidad> ObtenerTodas()

        public IEnumerable<Entidad> Buscar(Expression<Func<Entidad, bool>> predicado){
            return _unidadDeTrabajo.Set<Entidad>().Where(predicado);
        }//End IEnumerable<Entidad> Buscar(Expression<Func<Entidad, bool>> predicado)

        public Entidad BuscarSingleOrDefault(Expression<Func<Entidad, bool>> predicado) {
            return _unidadDeTrabajo.Set<Entidad>().Single(predicado);
        }//End BuscarSingleOrDefault(Expression<Func<Entidad, bool>> predicado)

        public void Agregar(Entidad entidad) {
            _unidadDeTrabajo.Set<Entidad>().Add(entidad);
        }//End Agregar(Entidad entidad)

        public void Eliminar(Entidad entidad) {
            _unidadDeTrabajo.Set<Entidad>().Remove(entidad);
        }//End  Eliminar(Entidad entidad)

        public void Dispose() {
            _unidadDeTrabajo.Dispose();
        }//End Dispose()

    }//End  class RepositorioBase<Entidad> : IRepositorioBase<Entidad> where Entidad: class

}//End namespace Datos.Persistencia.Repositorios.Clases
