using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Urun.Commands.CreateUrun
{
    public sealed record CreateUrunCommandResponse
    (string Message = "Ürün başarıyla eklendi");
}
