using Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Firma.Query.GetAllFirmaQuery
{
    public sealed class GetAllFirmaQueryHandler : IRequestHandler<GetAllFirmaQuery, GetAllFirmaQueryResponse>
    {
        private readonly IFirmaService _firmaService;

        public GetAllFirmaQueryHandler(IFirmaService firmaService)
        {
            _firmaService = firmaService;
        }

        public Task<GetAllFirmaQueryResponse> Handle(GetAllFirmaQuery request, CancellationToken cancellationToken)
        {
            GetAllFirmaQueryResponse response = new(_firmaService.GetAll());
            return response;
        }

        //public Task<GetAllFirmaQueryResponse> Handle(GetAllFirmaQuery request, CancellationToken cancellationToken)
        //{
        //    GetAllFirmaQueryResponse response = new(_firmaService.GetAll());
        //    return response;
        //}
    }
}
