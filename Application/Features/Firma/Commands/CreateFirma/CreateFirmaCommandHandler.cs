using Application.Services;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Firma.Commands.CreateFirma
{
    public sealed class CreateFirmaCommandHandler : IRequestHandler<CreateFirmaCommand, CreateFirmaCommandResponse>
    {
        private readonly IFirmaService _firmaService;
        public CreateFirmaCommandHandler(IFirmaService firmaService)
        {
            _firmaService = firmaService;
        }

        public async Task<CreateFirmaCommandResponse> Handle (CreateFirmaCommand request, CancellationToken cancellationToken)
        {
            await _firmaService.CreateFirmaAsync(request);
            return new();
        }
    }
}
