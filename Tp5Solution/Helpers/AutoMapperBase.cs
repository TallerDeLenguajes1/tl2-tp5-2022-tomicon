using AutoMapper;
using Tp5Solution.Models;
using Tp5Solution.ViewModels;

namespace Tp5Solution.Helpers
{
    public class AutoMapperBase
    {
        private static MapperConfiguration instance;

        public AutoMapperBase()
        {

        }

        public static MapperConfiguration Instance()
        {
            if (instance == null)
            {
                instance = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Pedido, PedidoViewModel>()
                    .ForMember(d => d.NumPedido, o => o.MapFrom(s => s.Nro))
                    .ForMember(d => d.TelefonoUsuario, o => o.MapFrom(s => s.Usuario.Telefono))
                    .ForMember(d => d.NombreUsuario, o => o.MapFrom(s => s.Usuario.Nombre))
                    .ForMember(d => d.ApellidoUsuario, o => o.MapFrom(s => s.Usuario.Apellido))
                    .ForMember(d => d.Direccion, o => o.MapFrom(s => s.Usuario.Direccion))
                    .ForMember(d => d.Observaciones, o => o.MapFrom(s => s.Obs))
                    .ForMember(d => d.DatosDireccion, o => o.MapFrom(s => s.Usuario.DatosReferenciaDireccion)).ReverseMap();

                    cfg.CreateMap<Cadete, CadeteViewModel>()
                    .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                    .ForMember(d => d.Nombre, o => o.MapFrom(s => s.Nombre))
                    .ForMember(d => d.Apellido, o => o.MapFrom(s => s.Apellido))
                    .ForMember(d => d.Telefono, o => o.MapFrom(s => s.Telefono)).ReverseMap();
                    
           
                });
            }

            return instance;
        }
    }
}
