namespace Cadeteria.ViewModels;
using  System.ComponentModel.DataAnnotations;

public class CadeteViewModel
{
    [Required]
    int id;
    [Required]
    [StringLength(50)]
    string nombre;
    [Required]
    [StringLength(15)]
    string telefono;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Telefono { get => telefono; set => telefono = value; }

    public CadeteViewModel()
    {
        
    }
}