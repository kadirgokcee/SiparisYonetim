using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Urun.Commands.CreateUrun
{
    public sealed record CreateUrunCommand
    ( string FirmaId,
        string UrunId,
        decimal Stok,
        decimal Price ): IRequest<CreateUrunCommandResponse>;
}
