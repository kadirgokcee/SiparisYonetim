using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Firma.Commands.CreateFirma
{
    public sealed record CreateFirmaCommand(
     string FirmaName,
     int SiparisBaslangicSaati,
     int SiparisBaslangicDakika,
     int SiparisBitisSaati,
     int SiparisBitisDakika) : IRequest<CreateFirmaCommandResponse>

    {

    }
}
