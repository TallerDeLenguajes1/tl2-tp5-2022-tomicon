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
}