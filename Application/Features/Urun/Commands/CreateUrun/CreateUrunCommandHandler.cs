using Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Urun.Commands.CreateUrun
{
    public sealed class CreateUrunCommandHandler : IRequestHandler<CreateUrunCommand, CreateUrunCommandResponse>
    {
        private readonly IUrunService _UrunService;

        public CreateUrunCommandHandler(IUrunService urunService)
        {
            _UrunService = urunService;
        }

        public async Task<CreateUrunCommandResponse> Handle(CreateUrunCommand request, CancellationToken cancellationToken)
        {
            await _UrunService.AddAsync(request);
            return new();
        }
    }
}
