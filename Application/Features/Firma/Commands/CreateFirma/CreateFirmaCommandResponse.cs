using MediatR;

namespace Application.Features.Firma.Commands.CreateFirma;

public sealed record CreateFirmaCommandResponse 
 (
    string Message = "Şirket kaydı başarıyla tamamlandı");


