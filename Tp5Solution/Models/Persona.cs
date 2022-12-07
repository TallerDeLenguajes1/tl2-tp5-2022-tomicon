namespace Tp5Solution.Models
{
    public class Persona
    {
        protected static int autonum = 0;
        protected int id;
        protected string nombre;
        protected string direccion;
        protected string telefono;
        protected string apellido;

        public Persona()
        {
            nombre = string.Empty;
            direccion = string.Empty;
            telefono = string.Empty;
            apellido = string.Empty;
        }

        public Persona(string nombre, string apellido, string direccion, string telefono)
        {
            autonum++;
            Id = autonum;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
        }


        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id { get => id; set => id = value; }
        
    }
}
