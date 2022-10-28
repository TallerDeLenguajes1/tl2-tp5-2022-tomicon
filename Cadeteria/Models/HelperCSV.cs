namespace Cadeteria.Models;
public class HelperCSV
{
    public List<Cadete> extraerCadetes()
    {
        List<Cadete> listaCadetes = new List<Cadete>();
        Cadete nuevoCadete= new Cadete();
        string nombreArchivo = "Cadetes.csv";
        foreach (var linea in File.ReadAllLines(nombreArchivo))
        {
            if (linea != "" && linea != "ID;Nombre;Apellido;Telefono")
            {
                var informacion = linea.Split(";");
                nuevoCadete.Id = Convert.ToInt32(informacion[0]);
                nuevoCadete.Nombre= informacion[1] + " " + informacion[2];
                nuevoCadete.Telefono= informacion[3];
                listaCadetes.Add(nuevoCadete);
            }
        }
        return listaCadetes;
    }
}