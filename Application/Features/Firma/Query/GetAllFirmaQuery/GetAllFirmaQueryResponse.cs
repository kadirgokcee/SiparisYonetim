

using Domain.Entities;

namespace Application.Features.Firma.Query.GetAllFirmaQuery
{
    public sealed record GetAllFirmaQueryResponse ( 
       IQueryable<Firma> Firmas);
    
}
