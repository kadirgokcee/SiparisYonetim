using Application.Services;
using MediatR;

namespace Application.Features.Siparis.Commands
{
    public sealed class CreateSiparisCommandHandler : IRequestHandler<CreateSiparisCommand, CreateSiparisCommandResponse>
    {
        private readonly ISiparisService _SiparisService;
        private readonly IFirmaService _FirmaService;
        public CreateSiparisCommandHandler(ISiparisService siparisService, IFirmaService firmaService)
        {
            _SiparisService = siparisService;
            _FirmaService = firmaService;
        }


        public async Task<CreateSiparisCommandResponse> Handle(CreateSiparisCommand request, CancellationToken cancellationToken)
        {
            Firma firma = await _FirmaService.GetFirmaById(request.FirmaId);
            if (!firma.ApprovalStatus) throw new Exception("Şirket aktif olmadığından sipariş alamıyor");
            int siparisBaslangicSaati = firma.SiparisİzinBaslangic;
            int siparisBaslangicDakikası = firma.SiparisİzinBaslangicDk;

            int siparisBitisSaati = firma.SiparisİzinBitis;
            int siparisBitisDakika = firma.SiparisİzinBitisDk;

            int nowHour = DateTime.Now.Hour;
            int nowMinute = DateTime.Now.Minute;

            if (siparisBaslangicSaati < nowHour)
            {
                if (siparisBitisSaati >= nowHour && siparisBitisDakika >= nowMinute)
                {
                    await _SiparisService.CreateSiparis(request);
                }
            }
            else if (siparisBaslangicSaati == nowHour)
            {

                if (siparisBaslangicDakikası < nowMinute)
                {
                    await _SiparisService.CreateSiparis(request);
                }

            }
            else { throw new Exception("Siparişiniz firmanın sipariş aldığ aralıklar dışında")}
            return new();
        }
    }
}
