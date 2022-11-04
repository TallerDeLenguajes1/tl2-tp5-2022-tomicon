using Cadeteria.Models;
using Cadeteria.ViewModels;
public static class CadeteMapper
{
    public static Cadete mappearACadete(CadeteViewModel viewmodel)
    {
        Cadete cadete = new Cadete();
        cadete.Id = viewmodel.Id;
        cadete.Nombre = viewmodel.Nombre;
        cadete.Telefono = viewmodel.Telefono;
        return cadete;
    }

    public static CadeteViewModel mappearACadeteViewModel(Cadete cadete)
    {
        CadeteViewModel viewModel = new CadeteViewModel();
        viewModel.Id = cadete.Id;
        viewModel.Nombre = cadete.Nombre;
        viewModel.Telefono = cadete.Telefono;
        return viewModel;
    }
}