using Cadeteria.Models;
using Cadeteria.ViewModels;
public static class CadeteMapper
{
    public static Cadete mappearACadete(CadeteViewModel viewmodel)
    {
        Cadete cadete = new Cadete();
        cadete.Id = viewmodel.Id;
        cadete.Nombre = viewmodel.Nombre + " " + viewmodel.Apellido;
        cadete.Telefono = viewmodel.Telefono;
        return cadete;
    }

    public static CadeteViewModel mappearACadeteViewModel(Cadete cadete)
    {
        CadeteViewModel viewModel = new CadeteViewModel();
        viewModel.Id = cadete.Id;
        var nombYApe= cadete.Nombre.Split(" ");
        viewModel.Nombre = nombYApe[0];
        viewModel.Apellido = nombYApe[1];
        viewModel.Telefono = cadete.Telefono;
        return viewModel;
    }
}

public static class PedidoMapper
{
    public static Pedido mappearAPedido(PedidoViewModel viewModel)
    {
        Pedido nuevo = new Pedido();
        nuevo.Estado = Estados.porSalir;
        nuevo.Obs = viewModel.Observaciones;
        string nombre= viewModel.NombreUsuario + " " + viewModel.ApellidoUsuario;
        string direccion= viewModel.Direccion;
        string telefono= viewModel.TelefonoUsuario;
        string datos = viewModel.DatosDireccion;
        nuevo.Usuario= new Cliente(nombre, direccion, telefono, datos);
        return nuevo;
    }

    public static PedidoViewModel mappearAPedidoViewModel(Pedido pedido)
    {
        PedidoViewModel viewModel= new PedidoViewModel();
        var nombreCompleto= pedido.Usuario.Nombre.Split(" ");
        viewModel.NombreUsuario= nombreCompleto[0];
        viewModel.ApellidoUsuario= nombreCompleto[1];
        viewModel.Direccion= pedido.Usuario.Direccion;
        viewModel.Observaciones= pedido.Obs;
        viewModel.TelefonoUsuario= pedido.Usuario.Telefono;
        viewModel.DatosDireccion= pedido.Usuario.DatosReferenciaDireccion;
        return viewModel;
    }
}