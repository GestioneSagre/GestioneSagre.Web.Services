using System.Net.Http.Json;
using GestioneSagre.Models.ViewModels.Versioni;
using GestioneSagre.Web.Services.Configuration;

namespace GestioneSagre.Web.Services.Services.Versioni;

public class VersioneService : IVersioneService
{
    private HttpClient httpClient;

    private string Versione = Settings.versione;
    private string PrivateAPI = Settings.privateAPI;

    public VersioneViewModel testoVersione { get; set; }

    public VersioneService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<VersioneViewModel> GetVersione()
    {
        testoVersione = await httpClient.GetFromJsonAsync<VersioneViewModel>($"{PrivateAPI}/api/versione/{Versione}");

        return testoVersione;
    }
}