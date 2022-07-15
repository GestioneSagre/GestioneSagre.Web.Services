using GestioneSagre.Models.InputModels.InvioEmail;

namespace GestioneSagre.Web.Services.Services.Supporto;

public interface ISupportoService
{
    Task InvioEmailSupporto(InputMailSender input);
}