using System.ComponentModel.DataAnnotations;

namespace Tp5Solution.ViewModels
{
    public class CadeteViewModel
    {
        
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }= string.Empty;
        [Required]
        [MaxLength(15)]
        public string Telefono { get; set; }= string.Empty;

        public CadeteViewModel()
        {
            if (File.Exists("Cadetes.csv"))
            {
                var lineas = File.ReadAllLines(@"Cadetes.csv");
                if (lineas.Length == 1)
                {
                    this.Id = 1;
                }
                else
                {
                    var infoLineas = lineas[lineas.Length - 1].Split(";");
                    int num = Convert.ToInt32(infoLineas[0]) + 1;
                    this.Id = num;
                }
            }
        }

        public CadeteViewModel(int id, string nombre, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Apellido= string.Empty;
        }
    }


}
