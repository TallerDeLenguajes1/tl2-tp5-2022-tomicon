// See https://aka.ms/new-console-template for more information
namespace Cadeteria.Models;
public class Cadete : Persona
{
    private List<Pedido> ListadoPedidos;

    public List<Pedido> ListadoPedidos1 { get => ListadoPedidos; set => ListadoPedidos = value; }

    public Cadete(int id, string nombre, string direccion, string telefono) : base(id, nombre, direccion, telefono)
    {
        ListadoPedidos1= new List<Pedido>();
    }

    public Cadete()
    {
    }

    public void agregarPedido(Pedido nuevo){
        ListadoPedidos1.Add(nuevo);
    }

    public void eliminarPedido(Pedido pedidoAEliminar){
        if (this.ListadoPedidos1.Remove(pedidoAEliminar))
        {
            System.Console.WriteLine("Exito al eliminar el pedido");
        } else
        {
            System.Console.WriteLine("no se pudo eliminar el pedido");
        }
        
    }

    public void comenzarEntrega(Pedido pedido){
        foreach (var encargo in this.ListadoPedidos1)
        {
            if (encargo== pedido)
            {
                encargo.cambiarEstado(Estados.enCamino);
            }
        }
    }

    public void entregarPedido(Pedido pedido){
        foreach (var encargo in this.ListadoPedidos1)
        {
            if (encargo== pedido)
            {
                encargo.cambiarEstado(Estados.entregado);
            }
        }
    }

    public double calcularJornal()
    {
        int canEntregados= 0;
        double pagoPorPedido= 300;
        foreach (var pedido in this.ListadoPedidos1)
        {
            if (pedido.Estado== Estados.entregado)
            {
                canEntregados++;
            }
        }
        return pagoPorPedido * canEntregados;
    }
}

