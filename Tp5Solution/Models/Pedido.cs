namespace Tp5Solution.Models
{
   
    public class Pedido
    {
        private static int autonum = 0;
        private int nro;
        private string obs;
        private Cliente usuario;
        private Estados estado;
        private int idCadete;

        public Pedido()
        {
            obs= string.Empty;
            usuario= new Cliente();

        }

        public Pedido(string obs, Cliente usuario, Estados estado, int idCadete)
        {
            Nro = ++autonum;
            Obs = obs;
            Usuario = usuario;
            Estado = estado;
            IdCadete = idCadete;
        }

        public Estados Estado { get => estado; set => estado = value; }
        public Cliente Usuario { get => usuario; set => usuario = value; }
        public string Obs { get => obs; set => obs = value; }
        public int Nro { get => nro; set => nro = value; }
        public int IdCadete { get => idCadete; set => idCadete = value; }

        public void CambiarEstado(Estados estado)
        {
            Estado = estado;
        }
    }
}
