using Application.Features.Firma.Commands.CreateFirma;
using Application.Features.Firma.Commands.UpdateFirma;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IFirmaService
    {
        Task CreateFirmaAsync(CreateFirmaCommand request);
        Task UptadeFirmaAsync(UpdateFirmaCommand request);
        IQueryable<Firma> GetAll();
        Task<Firma> GetFirmaById(string firmaId);
    }
}
