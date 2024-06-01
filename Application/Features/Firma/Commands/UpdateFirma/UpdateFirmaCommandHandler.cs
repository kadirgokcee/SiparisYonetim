using Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Firma.Commands.UpdateFirma
{
    public sealed class UpdateFirmaCommandHandler : IRequestHandler<UpdateFirmaCommand, UpdateFirmaCommandResponse>
    {
        private readonly IFirmaService _firmaService;
        public UpdateFirmaCommandHandler(IFirmaService firmaService)
        {
            _firmaService = firmaService;
        }

       public async Task<UpdateFirmaCommandResponse> Handle(UpdateFirmaCommand request, CancellationToken cancellationToken)
        {
            await _firmaService.UptadeFirmaAsync(request);
            return new();
        }
    }
}
