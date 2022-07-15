using GestioneSagre.Models.ViewModels.Versioni;

namespace GestioneSagre.Web.Services.Services.Versioni;

public interface IVersioneService
{
    Task<VersioneViewModel> GetVersione();
}