using Domain.Entities;
using Domain.Repositories.UrunRepo;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.UrunRepository
{
    public sealed class UrunQueryRepository : QueryRepository<Urun>, IUrunQueryRepository
    {
        public UrunQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
