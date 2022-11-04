// See https://aka.ms/new-console-template for more information
namespace Cadeteria.Models;
public class Cadeteria 
{
    private string nombre;
    private string telefono;
    private List<Cadete> listaCadetes;

    public Cadeteria(string nombre, string telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.listaCadetes = new List<Cadete>();
    }

    public void agregarCadete(string nombre, string direccion, string telefono)
    {
        Cadete nuevo= new Cadete(nombre, direccion, telefono);
        listaCadetes.Add(nuevo);
    }

    public void asignarPedidoACadete(Pedido pedido, int idCadete){
        bool bandera= true;
        foreach (var repartidor in this.listaCadetes)
        {
            if (repartidor.Id== idCadete)
            {
                repartidor.agregarPedido(pedido);
                bandera= false;
            }
        }
        if (!bandera)
        {
            System.Console.WriteLine("El pedido se asignó correctamente");
        } else
        {
            System.Console.WriteLine("No se pudo agregar el pedido al cadete");
        }
    }

    public void removerPedidoDeCadete(Pedido pedido, int idCadete){
        bool bandera= true;
        foreach (var repartidor in this.listaCadetes)
        {
            if (repartidor.Id == idCadete)
            {
                repartidor.eliminarPedido(pedido);
            }
        }
        if (!bandera)
        {
            System.Console.WriteLine("El pedido se elimino correctamente");
        } else
        {
            System.Console.WriteLine("No se pudo eliminar el pedido al cadete");
        }
    }

    public void cambiarPedidoDeCadete(Pedido pedido, int idCadeteEntrega, int idCadeteNoEntrega){
        foreach (var repartidor in listaCadetes)
        {
            if (repartidor.Id==idCadeteNoEntrega)
            {
                repartidor.eliminarPedido(pedido);
            }
            if (repartidor.Id==idCadeteEntrega)
            {
                repartidor.agregarPedido(pedido);
            }
        }
    }

    public void cadeteComenzoEntrega(int idCadete, Pedido pedido){
        foreach (var repartidor in this.listaCadetes)
        {
            if (repartidor.Id == idCadete)
            {
                repartidor.comenzarEntrega(pedido);
            }
        }
    }

    public void cadeteRealizoEntrega(int idCadete, Pedido pedido){
        foreach (var repartidor in this.listaCadetes)
        {
            if (repartidor.Id == idCadete)
            {
                repartidor.entregarPedido(pedido);
            }
        }
    }

    public double calcularJornalCadete(int idCadete){
        double monto=0;
        foreach (var repartidor in this.listaCadetes)
        {
            if (repartidor.Id==idCadete)
            {
                monto = repartidor.calcularJornal();
            }
        }
        return monto;
    }

    public void mostrarInforme(){
        int totalPedidos=0;
        int pedidosPorCadete=0;
        double montoTotal=0;
        foreach (var repartidor in listaCadetes)
        {
            System.Console.WriteLine("cant envios del cadete nro" + repartidor.Id+": " + repartidor.ListadoPedidos1.Count());
            totalPedidos += repartidor.ListadoPedidos1.Count();
            montoTotal += repartidor.calcularJornal();
        }
        System.Console.WriteLine("cant total de pedidos: "+ totalPedidos);
        System.Console.WriteLine("Promedio de pedidos x cadete: " + (totalPedidos/this.listaCadetes.Count()));
        System.Console.WriteLine("Monto total: "+ montoTotal);
    }
}