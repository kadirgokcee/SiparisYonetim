using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Siparis : Entity
    {
        public string MüsteriAdi { get; set; }
        public DateTime SiparisSaati { get; set; }

        public string FirmaId { get; set; }
        public string UrunId { get; set; }
        public Urun Urun { get; set; }
    }
}
