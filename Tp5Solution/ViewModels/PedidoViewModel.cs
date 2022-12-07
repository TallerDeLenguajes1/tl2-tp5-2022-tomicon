using System.ComponentModel.DataAnnotations;

namespace Tp5Solution.ViewModels
{
    public class PedidoViewModel
    {
        [Required]
        [MaxLength(50)]
        public string NombreUsuario { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string ApellidoUsuario { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string Direccion { get; set; } = string.Empty;
        [Required]
        [MaxLength(15)]
        public string TelefonoUsuario { get; set; } = string.Empty;
        [Required]
        [MaxLength(150)]
        public string DatosDireccion { get; set; } = string.Empty;
        [Required]
        [MaxLength(350)]
        public string Observaciones { get; set; } = string.Empty;
        public int NumPedido { get; set; }

        public PedidoViewModel()
        {
            if (File.Exists("Pedidos.csv"))
            {
                var lineas = File.ReadAllLines(@"Pedidos.csv");
                if (lineas.Length == 1)
                {
                    this.NumPedido = 1;
                }
                else
                {
                    var infoLineas = lineas[lineas.Length - 1].Split(";");
                    int num = Convert.ToInt32(infoLineas[0]) + 1;
                    this.NumPedido = num;
                }
            }
        }
    }
}
