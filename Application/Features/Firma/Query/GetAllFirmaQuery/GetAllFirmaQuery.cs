using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Firma.Query.GetAllFirmaQuery
{
    public sealed record  GetAllFirmaQuery : IRequest <GetAllFirmaQueryResponse>;
    
}
