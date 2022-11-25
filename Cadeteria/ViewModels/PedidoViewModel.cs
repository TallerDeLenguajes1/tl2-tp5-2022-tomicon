namespace Cadeteria.ViewModels;
using  System.ComponentModel.DataAnnotations;

public class PedidoViewModel
{
    int numPedido;
    [Required]
    [StringLength(50)]
    string nombreUsuario;
    [Required]
    [StringLength(50)]
    string apellidoUsuario;
    [Required]
    [StringLength(50)]
    string direccion;
    [Required]
    [StringLength(15)]
    string telefonoUsuario;
    [StringLength(150)]
    string datosDireccion;
    [StringLength(350)]
    string observaciones;

    public string NombreUsuario {get => NombreUsuario; set => NombreUsuario = value; }
    public string ApellidoUsuario { get => apellidoUsuario; set => apellidoUsuario = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string TelefonoUsuario { get => telefonoUsuario; set => telefonoUsuario = value; }
    public string DatosDireccion { get => datosDireccion; set => datosDireccion = value; }
    public string Observaciones { get => observaciones; set => observaciones = value; }
    public int NumPedido { get => numPedido; set => numPedido = value; }

    public PedidoViewModel()
    {
                if (File.Exists("Pedidos.csv"))
        {
            var lineas= File.ReadAllLines(@"Pedidos.csv");
            if (lineas.Length==0)
            {
                this.NumPedido=0;
            } else
            {
                var infoLineas= lineas[lineas.Length -1 ].Split(";");
                int num = Convert.ToInt32(infoLineas[0]) + 1;
                this.NumPedido= num;  
            }
        }
    }
}