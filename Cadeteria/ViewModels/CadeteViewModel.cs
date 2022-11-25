
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
    [StringLength(50)]
    string apellido;
    [Required]
    [StringLength(15)]
    string telefono;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public string Telefono { get => telefono; set => telefono = value; }

    public CadeteViewModel()
    {
        if (File.Exists("Cadetes.csv"))
        {
            var lineas= File.ReadAllLines(@"Cadetes.csv");
            if (lineas.Length==0)
            {
                this.Id=0;
            } else
            {
                var infoLineas= lineas[lineas.Length -1 ].Split(";");
                int num = Convert.ToInt32(infoLineas[0]) + 1;
                this.Id= num;  
            }
        }
    }

    public CadeteViewModel(int id, string nombre, string telefono)
    {
        Id = id;
        Nombre = nombre;
        Telefono = telefono;
    }
}