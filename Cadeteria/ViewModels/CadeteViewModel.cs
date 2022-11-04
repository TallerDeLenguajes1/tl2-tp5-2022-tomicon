namespace Cadeteria.ViewModels;

public class CadeteViewModel
{
    int id;
    string nombre;
    string telefono;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Telefono { get => telefono; set => telefono = value; }
}