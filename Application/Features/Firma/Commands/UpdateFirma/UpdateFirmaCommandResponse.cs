using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Firma.Commands.UpdateFirma
{
    public sealed record UpdateFirmaCommandResponse(
        string Message = "Şirket kaydı başarıyla güncellendi");
    
}
