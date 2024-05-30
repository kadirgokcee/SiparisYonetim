using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Firma : Entity
    {
        public string FirmaAdi { get; set; }
        public bool OnayDurumu { get; set; }
        public int SiparisİzinBaslangic { get; set; }
        public int SiparisİzinBaslangicDk { get; set; }
        public int SiparisİzinBitis { get; set; }
        public int SiparisİzinBitisDk { get; set; }
        public ICollection<Urun> Urun { get; set; }

    }
}
