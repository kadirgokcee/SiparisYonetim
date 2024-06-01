﻿using Domain.Entities;
using Domain.Repositories.SiparisRepo;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.SiparisRepository
{
    public sealed class SiparisQueryRepository : QueryRepository<Siparis>, ISiparisQueryRepository
    {
        public SiparisQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
