using Cadeteria.Models;
public static class HelperDeArchivos
{
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
}