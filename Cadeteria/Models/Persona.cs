// See https://aka.ms/new-console-template for more information
namespace Cadeteria.Models;

public class Persona
{
    protected static int autonum= 0;
    protected int id;
    protected string nombre;
    protected string direccion;
    protected string telefono;

    public Persona(){

    }

    public Persona(string nombre, string direccion, string telefono)
    {
        autonum++;
        this.Id = autonum;
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;
    }

    public string Telefono { get => telefono; set => telefono = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Id { get => id; set => id = value; }
}
