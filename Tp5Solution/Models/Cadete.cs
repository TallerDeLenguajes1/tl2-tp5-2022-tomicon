namespace Tp5Solution.Models
{
    public class Cadete : Persona
    {

        private List<Cadete> listaCadetes;
        private List<Pedido> listaPedidos;

        public Cadete() : base()
        {
            listaCadetes = new List<Cadete>();
            listaPedidos = new List<Pedido>();
        }

        public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
        public List<Cadete> ListaCadetes { get => listaCadetes; set => listaCadetes = value; }


        public Cadete(string nombre, string apellido, string direccion, string telefono) : base(nombre, apellido, direccion, telefono)
        {
            listaCadetes = new List<Cadete>();
            listaPedidos = new List<Pedido>();
        }

        public void AsignarPedidoACadete(int nro)
        {
            Random r = new Random();
            int indice = ListaCadetes.Count();
            int idCadete = ListaCadetes[indice].Id;

            foreach (var encargo in ListaPedidos)
            {
                if (encargo.Nro == nro)
                {
                    encargo.IdCadete = idCadete;
                }
            }
        }

        public void AgregarPedido(Pedido pedido)
        {
            ListaPedidos.Add(pedido);
        }

        public void CambiarPedidoDeCadete(int nro, int idCadete)
        {
            foreach (var pedido in ListaPedidos)
            {
                if (pedido.Nro == nro)  
                {
                    pedido.IdCadete=idCadete;
                }
            }
        }
    }
}
