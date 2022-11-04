// See https://aka.ms/new-console-template for more information
namespace Cadeteria.Models;

public enum Estados {entregado, enCamino, porSalir};
public class Pedido
{
    private static int autonum=0;
    private int nro;
    private string obs;
    private Cliente usuario;
    private Estados estado;

    public Pedido(string obs, Estados estado, int id, string nombre, string direccion, string telefono, string datosDirec)
    {
        Nro = ++autonum;
        Obs = obs;
        usuario = new Cliente(nombre, direccion, telefono, datosDirec);
        Estado = estado;
    }

    public Estados Estado { get => estado; set => estado = value; }
    public Cliente Usuario { get => usuario; set => usuario = value; }
    public string Obs { get => obs; set => obs = value; }
    public int Nro { get => nro; set => nro = value; }

    public void cambiarEstado(Estados nuevo){
        this.Estado= nuevo;
    }
    
}

