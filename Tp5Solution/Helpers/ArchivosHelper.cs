using Tp5Solution.Models;

namespace Tp5Solution.Helpers
{
    public static class ArchivosHelper
    {
        public static void InsertarCadete(Cadete cadete)
        {
            string linea = $"{cadete.Id};{cadete.Nombre};{cadete.Apellido};{cadete.Telefono}";
            string nombreArchivo = "Cadetes.csv";
            bool archivoExiste = System.IO.File.Exists(nombreArchivo);
            StreamWriter escritor = System.IO.File.AppendText(nombreArchivo);
            if (!archivoExiste)
            {
                escritor.WriteLine("ID;Nombre;Apellido;Telefono");
            }
            escritor.WriteLine(linea);
            escritor.Close();
        }

        public static List<Cadete> LeerCadetes()
        {
            string nombreArchivo = "Cadetes.csv";
            List<Cadete> listadoCadetes = new List<Cadete>();
            foreach (var linea in File.ReadAllLines(nombreArchivo))
            {
                if (linea != "" && linea != "ID;Nombre;Apellido;Telefono")
                {
                    Cadete nuevo = new Cadete();
                    var informacion = linea.Split(";");
                    nuevo.Id = Convert.ToInt32(informacion[0]);
                    nuevo.Nombre = informacion[1] + " " + informacion[2];
                    nuevo.Telefono = informacion[3];
                    listadoCadetes.Add(nuevo);
                }
            }
            return listadoCadetes;
        }

        public static void EliminarCadete(string idCadete)
        {
            string nombreArchivo = "Cadetes.csv";
            List<string> lineasCadetes = new List<string>();
            foreach (var linea in System.IO.File.ReadAllLines(nombreArchivo))
            {
                if (linea != "")
                {
                    var informacion = linea.Split(";");
                    string id = informacion[0];
                    if (id != idCadete)
                    {
                        string datosCadete = $"{informacion[0]};{informacion[1]};{informacion[2]};{informacion[3]}";
                        lineasCadetes.Add(datosCadete);
                    }
                }
            }
            System.IO.File.Delete("Cadetes.csv");
            System.IO.File.WriteAllLines("Cadetes.csv", lineasCadetes);
        }

        public static void InsertarPedido(Pedido nuevo)
        {
            var linea = $"{Convert.ToString(nuevo.Nro)};{nuevo.Usuario.Nombre};{nuevo.Usuario.Apellido};{nuevo.Usuario.Telefono};{nuevo.Usuario.Direccion};{nuevo.Usuario.DatosReferenciaDireccion};{nuevo.Obs}";
            string nombreArchivo = "Pedidos.csv";
            bool archivoExiste = System.IO.File.Exists(nombreArchivo);
            StreamWriter escritor = System.IO.File.AppendText(nombreArchivo);
            if (!archivoExiste)
            {
                escritor.WriteLine("Nro;NombreCliente;ApeCliente;TelCliente;Direc;DatosDirec;Observaciones");
            }
            escritor.WriteLine(linea);
            escritor.Close();
        }

        public static List<Pedido> LeerPedidos()
        {
            string nombreArchivo = "Pedidos.csv";
            List<Pedido> listadoPedidos = new List<Pedido>();
            foreach (var linea in File.ReadAllLines(nombreArchivo))
            {
                if (linea != "" && linea != "Nro;NombreCliente;ApeCliente;TelCliente;Direc;DatosDirec;Observaciones")
                {
                    Pedido nuevo = new Pedido();
                    Cliente usuario = new Cliente();
                    var informacion = linea.Split(";");
                    nuevo.Nro = Convert.ToInt32(informacion[0]);
                    usuario.Nombre = informacion[1] + " " + informacion[2];
                    usuario.Telefono = informacion[3];
                    usuario.Direccion = informacion[4];
                    usuario.DatosReferenciaDireccion = informacion[5];
                    nuevo.Usuario = usuario;
                    nuevo.Obs = informacion[6];
                    listadoPedidos.Add(nuevo);
                }
            }
            return listadoPedidos;
        }

        public static void EliminarPedido(string numPedido)
        {
            string nombreArchivo = "Pedidos.csv";
            List<string> lineasPedido = new List<string>();
            foreach (var linea in System.IO.File.ReadAllLines(nombreArchivo))
            {
                if (linea != "")
                {
                    var informacion = linea.Split(";");
                    string num = informacion[0];
                    if (num != numPedido)
                    {
                        string datosPedido = $"{informacion[0]};{informacion[1]};{informacion[2]};{informacion[3]};{informacion[4]};{informacion[5]};{informacion[6]}";
                        lineasPedido.Add(datosPedido);
                    }
                }
            }
            System.IO.File.Delete("Pedidos.csv");
            System.IO.File.WriteAllLines("Pedidos.csv", lineasPedido);
        }
    }
}
