// See https://aka.ms/new-console-template for more information
namespace Cadeteria.Models;
public class Cadeteria 
{
    private string nombre;
    private string telefono;
    private List<Cadete> listaCadetes;
    private List<Pedido> listaPedidos;

    public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
    public List<Cadete> ListaCadetes { get => listaCadetes; set => listaCadetes = value; }

    public Cadeteria(string nombre, string telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.ListaCadetes = new List<Cadete>();
        this.listaPedidos = new List<Pedido>();
    }

    public void agregarCadete(string nombre, string direccion, string telefono)
    {
        Cadete nuevo= new Cadete(nombre, direccion, telefono);
        ListaCadetes.Add(nuevo);
    }

    public void asignarPedidoACadete(int nro)
    {
        Random r = new Random();
        int indice = ListaCadetes.Count();
        int idCadete = ListaCadetes[indice].Id;
        
        foreach (var encargo in ListaPedidos)
        {
            if (encargo.Nro == nro)
            {
                encargo.IdCadete= idCadete;
            }
        }
    }

    public void agregarPedido(Pedido pedido){
        this.ListaPedidos.Add(pedido);
    }

    public void cambiarPedidoDeCadete(int nro, int idCadete){
        foreach (var pedido in ListaPedidos)
        {
            if (pedido.Nro == nro)
            {
                pedido.IdCadete = idCadete;
            }
        }
    }
}