using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.Contrato;
using Aplicacion.Core;
using AutoMapper;
using Dominio.Contratos;
using Dominio.Core;

namespace Aplicacion.Implementacion{

    public class AdministradorServicio : IAdministradorServicio {

        #region Atributos

        private IAdministradorRepositorio _administradorRepositorio;

        #endregion

        #region Constructor
        public AdministradorServicio(IAdministradorRepositorio pAdministradorRepositorio) {
            _administradorRepositorio = pAdministradorRepositorio;
        }

        #endregion

        #region Metodos

        public AdministradorDTO Obtener(int id) {
            var objetoRecuperado = _administradorRepositorio.Obtener(id);
            return Mapper.Map<Administrador, AdministradorDTO>(objetoRecuperado);
        }

        public IEnumerable<AdministradorDTO> ObtenerTodas() {
            var lista = _administradorRepositorio.ObtenerTodas();
            return Mapper.Map<IEnumerable<Administrador>, IEnumerable<AdministradorDTO>>(lista);
        }

        public IEnumerable<AdministradorDTO> BuscarPorNombre(String pNombre) {
            var lista = _administradorRepositorio.Buscar(x => x.AdministradorNombre.ToUpper().Equals(pNombre.ToUpper()));
            return Mapper.Map<IEnumerable<Administrador>, IEnumerable<AdministradorDTO>>(lista);

        }

        public AdministradorDTO BuscarUnoPorCorreo(String pCorreo) {
            var objetoRecuperado = _administradorRepositorio.BuscarSingleOrDefault(x => x.AdministradorCorreo.ToUpper().Equals(pCorreo.ToUpper()));
            return Mapper.Map<Administrador, AdministradorDTO>(objetoRecuperado);
        }

        public bool Agregar(AdministradorDTO entidad) {
            try {
                var _objetoInsertar = new Administrador();
                Mapper.Map(entidad, _objetoInsertar);
                _administradorRepositorio.Agregar(_objetoInsertar);
                _administradorRepositorio.UnidadDeTrabajo.Completar();
                return true;
            } catch {
                return false;
            }
        }

        public bool Eliminar(AdministradorDTO entidad) {
            try
            {
                var _objetoEliminar = new Administrador();
                Mapper.Map(entidad, _objetoEliminar);
                _administradorRepositorio.Eliminar(_objetoEliminar);
                _administradorRepositorio.UnidadDeTrabajo.Completar();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Dispose
        ~AdministradorServicio() {

        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        protected virtual void Dispose(bool disposing) {
            if (disposing) {
                if (_administradorRepositorio != null) {
                    _administradorRepositorio.Dispose();
                    _administradorRepositorio = null;
                }
            }
        } 
        #endregion
    }
}
