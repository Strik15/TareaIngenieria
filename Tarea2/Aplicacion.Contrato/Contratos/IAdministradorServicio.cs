using System;
using System.Collections.Generic;
using Aplicacion.Core;


namespace Aplicacion.Contrato{
    public interface IAdministradorServicio : IDisposable {
        AdministradorDTO Obtener(int id);

        IEnumerable<AdministradorDTO> ObtenerTodas();

        IEnumerable<AdministradorDTO> BuscarPorNombre(String pNombre);

        AdministradorDTO BuscarUnoPorCorreo(String pCorreo);

        bool Agregar(AdministradorDTO entidad);

        bool Eliminar(AdministradorDTO entidad);
    }

}
