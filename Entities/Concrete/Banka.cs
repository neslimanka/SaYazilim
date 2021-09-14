using Entities.Abstract;

namespace Entities
{
    public class Banka:IEntity
    {
        public int Id { get; set; }
        public int BankaKodu { get; set; }
        public string BankaAdi { get; set; }
        public string SubeAdi { get; set; }
        public int HesapNo { get; set; }
        public int Iban { get; set; }
    }

}
