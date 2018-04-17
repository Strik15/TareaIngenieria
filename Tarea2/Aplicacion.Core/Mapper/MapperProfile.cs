using AutoMapper;
using Dominio.Core;

namespace Aplicacion.Core{
    public class MapperProfile : Profile{

        public MapperProfile() {
            CreateMap<Administrador, AdministradorDTO>();
            CreateMap<AdministradorDTO, Administrador>();
        }//End constructor

    }//End class MapperProfile : Profile
}//End namespace Aplicacion.Core
