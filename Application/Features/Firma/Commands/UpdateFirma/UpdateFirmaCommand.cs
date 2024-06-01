using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Firma.Commands.UpdateFirma
{
    public sealed record UpdateFirmaCommand (
        string FirmaId,
        int SiparisBaslangicSaati,
        int SiparisBaslangicDakika ) : IRequest <UpdateFirmaCommandResponse>;
   
}
