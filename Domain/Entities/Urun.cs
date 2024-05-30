using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Urun : Entity
    {
        public string UrunAdi { get; set; }
        public decimal Stok { get; set; }
        public decimal Fiyat { get; set; }

        public string FirmaId { get; set; }
        public Firma Firma { get; set; }

        public ICollection<Siparis> Siparis { get; set; }
    }
}
