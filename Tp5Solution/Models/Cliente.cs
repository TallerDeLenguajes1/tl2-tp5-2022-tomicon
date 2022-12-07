namespace Tp5Solution.Models
{
    public class Cliente : Persona
    {
        private string datosReferenciaDireccion;

        public Cliente()
        {
            datosReferenciaDireccion = string.Empty;
        }
        public Cliente(string nombre, string apellido, string direccion, string telefono, string datosReferenciaDireccion) : base(nombre, apellido, direccion, telefono)
        {
            this.datosReferenciaDireccion = datosReferenciaDireccion;
        }

        public string DatosReferenciaDireccion { get => datosReferenciaDireccion; set => datosReferenciaDireccion = value; }
    }
}
