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
    public sealed class UrunCommandRepository : CommandRepository<Urun>, IUrunCommandRepository
    {
        public UrunCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
