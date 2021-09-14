using Core.Entities;


namespace Entities
{
    public class Kasa:IEntity
    {
        public int Id { get; set; }
        public int KasaKodu { get; set; }
        public string KasaAdi { get; set; }
    }

}
