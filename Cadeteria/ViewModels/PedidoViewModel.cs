public class PedidoViewModel
{
    string nombreUsuario;
    string apellidoUsuario;
    string direccion;
    string telefonoUsuario;
    string datosDireccion;
    string observaciones;

    public string NombreUsuario {get => NombreUsuario; set => NombreUsuario = value; }
    public string ApellidoUsuario { get => apellidoUsuario; set => apellidoUsuario = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string TelefonoUsuario { get => telefonoUsuario; set => telefonoUsuario = value; }
    public string DatosDireccion { get => datosDireccion; set => datosDireccion = value; }
    public string Observaciones { get => observaciones; set => observaciones = value; }

    public PedidoViewModel()
    {

    }
}