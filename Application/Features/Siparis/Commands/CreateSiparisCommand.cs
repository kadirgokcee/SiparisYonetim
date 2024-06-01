using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Siparis.Commands
{
    public sealed record CreateSiparisCommand
    (string FirmaId,
        string UrunId,
        string MusteriAdi) : IRequest<CreateSiparisCommandResponse>;
}
