using Domain.Entities;
using Domain.Repositories.FirmaRepo;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.FirmaRepository
{
    public sealed class FirmaQueryRepository : QueryRepository<Firma>, IFirmaQueryRepository
    {
        public FirmaQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
