using Application.Features.Urun.Commands.CreateUrun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IUrunService
    {
        Task AddAsync(CreateUrunCommand request);
    }
}
