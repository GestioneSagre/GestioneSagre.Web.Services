using System.Net.Http.Json;
using GestioneSagre.Models.InputModels.InvioEmail;
using GestioneSagre.Web.Services.Configuration;

namespace GestioneSagre.Web.Services.Services.Supporto;

public class SupportoService : ISupportoService
{
    private HttpClient httpClient;

    private string PrivateAPI = Settings.privateAPI;

    public SupportoService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task InvioEmailSupporto(InputMailSender inputModel)
    {
        var response = await httpClient.PostAsJsonAsync($"{PrivateAPI}/api/Email/InvioEmail", inputModel);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Richiesta di supporto non inviata a causa di un problema tecnico.");
        }
    }
}