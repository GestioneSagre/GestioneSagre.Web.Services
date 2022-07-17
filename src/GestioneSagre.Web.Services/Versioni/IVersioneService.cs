using GestioneSagre.Models.ViewModels.Versioni;

namespace GestioneSagre.Web.Services.Versioni;

public interface IVersioneService
{
    Task<VersioneViewModel> GetVersione();
}