using Cadeteria.Models;
using Cadeteria.ViewModels;
public static class HelperDeArchivos
{
    public static void insertarCadete(Cadete cadete)
    {
        var nombYape= cadete.Nombre.Split(" ");
        string linea= $"{cadete.Id};{nombYape[0]};{nombYape[1]};{cadete.Telefono}";
        string nombreArchivo= "Cadetes.csv";
        bool archivoExiste= System.IO.File.Exists(nombreArchivo);
        StreamWriter escritor = System.IO.File.AppendText(nombreArchivo);
        if (!archivoExiste)
        {
            escritor.WriteLine("ID;Nombre;Apellido;Telefono");
        }
        escritor.WriteLine(linea);
        escritor.Close();
    }

    public static List<Cadete> leerCadetes()
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

    public static void eliminarCadete(string idCadete)
    {
        string nombreArchivo = "Cadetes.csv";
        List<string> lineasCadetes = new List<string>();
        foreach (var linea in System.IO.File.ReadAllLines(nombreArchivo))
        {
            if (linea != "")
            {
                var informacion = linea.Split(";");
                string id = informacion[0];
                if (id != idCadete.Trim())
                {
                    string datosCadete = $"{informacion[0]};{informacion[1]};{informacion[2]};{informacion[3]}";
                    lineasCadetes.Add(datosCadete);
                }
            }
        }
        System.IO.File.Delete("Cadetes.csv");
        System.IO.File.WriteAllLines("Cadetes.csv", lineasCadetes);
    }

    public static void insertarPedido(string nombUsuario, string apeUsuario, string telUsuario, string direcUsuario, string datosDirec)
    {
        Pedido nuevo = new Pedido();
        var linea = $"{Convert.ToString(nuevo.Nro)};{nombUsuario};{apeUsuario};{telUsuario};{direcUsuario};{datosDirec}";
        string nombreArchivo= "Pedidos.csv";
        bool archivoExiste= System.IO.File.Exists(nombreArchivo);
        StreamWriter escritor = System.IO.File.AppendText(nombreArchivo);
        if (!archivoExiste)
        {
            escritor.WriteLine("Nro;NombreCliente;ApeCliente;TelCliente;Direc;DatosDirec");
        }
        escritor.WriteLine(linea);
        escritor.Close();
    }
}