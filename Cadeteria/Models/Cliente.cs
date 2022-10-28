// See https://aka.ms/new-console-template for more information
namespace Cadeteria.Models;
public class Cliente : Persona
{
    private string datosReferenciaDireccion;

    public Cliente(int id, string nombre, string direccion, string telefono, string datosDirec) : base(id, nombre, direccion, telefono)
    {
        this.DatosReferenciaDireccion= datosDirec;
    }

    public string DatosReferenciaDireccion { get => datosReferenciaDireccion; set => datosReferenciaDireccion = value; }
}