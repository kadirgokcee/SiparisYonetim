using Domain.Entities;
using Domain.Repositories;
using Domain.Repositories.FirmaRepo;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.FirmaRepository
{
    public sealed class FirmaCommandRepository : CommandRepository<Firma>, IFirmaCommandRepository
    {
        public FirmaCommandRepository(AppDbContext context) : base (context)
        {
        }
    }
}
