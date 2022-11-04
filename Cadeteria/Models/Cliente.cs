// See https://aka.ms/new-console-template for more information
namespace Cadeteria.Models;
public class Cliente : Persona
{
    private string datosReferenciaDireccion;

    public Cliente(string nombre, string direccion, string telefono, string datosDirec) : base(nombre, direccion, telefono)
    {
        this.DatosReferenciaDireccion= datosDirec;
    }

    public string DatosReferenciaDireccion { get => datosReferenciaDireccion; set => datosReferenciaDireccion = value; }
}