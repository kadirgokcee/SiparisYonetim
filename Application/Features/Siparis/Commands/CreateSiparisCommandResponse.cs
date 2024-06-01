using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Siparis.Commands
{
    public sealed record CreateSiparisCommandResponse
    (string Message = "Siparişiniz başarıyla oluşturuldu");
}
