using System;

namespace Entities
{
    public class Tahsilat_odeme
    {
        public int Id { get; set; }
        public int IslemTipi { get; set; }
        public int IslemNo { get; set; }
        public DateTime IslemTarih { get; set; }
        public int KasaId { get; set; }
        public int BankaId { get; set; }
        public string Aciklama { get; set; }
        public string ParaBirimi { get; set; }
        public int Tutar { get; set; }
    }

}
