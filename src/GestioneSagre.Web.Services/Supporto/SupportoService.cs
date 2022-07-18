using System.Net.Http.Json;
using GestioneSagre.Models.InputModels.InvioEmail;

namespace GestioneSagre.Web.Services.Supporto;

public class SupportoService : ISupportoService
{
    private HttpClient httpClient;

    public SupportoService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task InvioEmailSupportoAsync(InputMailSupportoSender inputModel)
    {
        var response = await httpClient.PostAsJsonAsync($"/api/Email/InvioEmailSupporto", inputModel);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Richiesta di supporto non inviata a causa di un problema tecnico.");
        }
    }
}