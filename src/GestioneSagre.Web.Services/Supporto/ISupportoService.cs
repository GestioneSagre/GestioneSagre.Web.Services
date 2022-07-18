using GestioneSagre.Models.InputModels.InvioEmail;

namespace GestioneSagre.Web.Services.Supporto;

public interface ISupportoService
{
    Task InvioEmailSupporto(InputMailSupportoSender input);
}